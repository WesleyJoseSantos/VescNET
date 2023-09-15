using System;
using System.IO.Ports;
using VescNET.Domain.DTOs;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class BldcSerial : IBldcComm
    {
        bool connected = false;

        private readonly IPacket packet;

        private readonly SerialPort serial;

        public bool Connected => connected && serial.IsOpen;

        public event EventHandler<ReceivedData> OnData;

        public event EventHandler<bool> ConnectionChanged;

        public BldcSerial(IPacket packet, SerialPort serial)
        {
            this.packet = packet;
            this.serial = serial;
            this.serial.ReadTimeout = 100;
            this.serial.DataReceived += Serial_DataReceived;
            this.serial.ErrorReceived += Serial_ErrorReceived;
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serial.BytesToRead != 0)
            {
                ProcessByte((byte)serial.ReadByte());
            }
        }

        private void Serial_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {
            if (e.EventType == SerialError.RXOver || e.EventType == SerialError.Overrun)
            {
                connected = false;
                ConnectionChanged?.Invoke(this, connected);
            }
        }

        private void ProcessByte(byte @byte)
        {
            var result = packet.ProcessRX(@byte);
            if (result == Domain.Enums.PacketProcessState.Done)
            {
                OnData?.Invoke(this, packet.ReceivedData);
                if(connected == false)
                {
                    connected = true;
                    ConnectionChanged?.Invoke(this, connected);
                }
            }
        }

        public void Send(IBuffer buffer)
        {
            if(serial.IsOpen)
            {
                var result = packet.ProcessTX(buffer.Data);
                serial.Write(result, 0, result.Length);
            }
        }

        public bool Connect(IBldc bldc)
        {
            var ports = SerialPort.GetPortNames();
            byte[] buffer = new byte[64];

            foreach(var port in ports) 
            {
                if (serial.IsOpen) serial.Close();
                serial.PortName = port;
                try
                {
                    serial.Open();
                    serial.DiscardInBuffer();
                    bldc.GetFwVersion();
                    var bytes = serial.Read(buffer, 0, 64);
                    for (int i = 0; i < bytes; i++)
                    {
                        ProcessByte(buffer[i]);
                    }
                    if (connected)
                    {
                        return true;
                    }
                }
                catch (Exception)
                {

                }
            }

            return false;
        }

        public void Disconnect()
        {
            serial.Close();
            connected = false;
            ConnectionChanged?.Invoke(this, connected);
        }
    }
}
