using System;
using System.IO;
using System.IO.Ports;
using System.Threading;
using VescNET.Domain.DTOs;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class BldcSerial : IBldcComm
    {
        bool connected = false;

        bool init = false;

        private readonly IPacket packet;

        private readonly SerialPort serial;

        public bool Connected => connected && serial.IsOpen;

        public event EventHandler<ReceivedData> OnData;

        public event EventHandler<bool> ConnectionChanged;

        public BldcSerial(IPacket packet, SerialPort serial)
        {
            this.packet = packet;
            this.serial = serial;
            this.serial.ReadTimeout = 500;
            this.serial.WriteTimeout = 500;
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
                if(connected)
                {
                    OnData?.Invoke(this, packet.ReceivedData);
                }
                if(connected == false && packet.ReceivedData.PacketId == Domain.Enums.CommPacketId.FwVersion)
                {
                    var info = packet.ReceivedData.Data as DeviceInfo;
                    if(info.HardwareVersion == "410" && info.FirmwareVersion == "6.0")
                    {
                        connected = true;
                        if(init == false)
                        {
                            serial.DataReceived += Serial_DataReceived;
                            serial.ErrorReceived += Serial_ErrorReceived;
                            init = true;
                        }
                        OnData?.Invoke(this, packet.ReceivedData);
                        ConnectionChanged?.Invoke(this, connected);
                    }
                    else
                    {
                        Console.WriteLine("Invalid VESC Data. Hardware: " + info.HardwareVersion + " Firmware: " + info.FirmwareVersion);
                    }
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

            if(connected && !serial.IsOpen)
            {
                Disconnect();
            }

            foreach(var port in ports) 
            {
                if (serial.IsOpen) Disconnect();
                serial.PortName = port;
                try
                {
                    serial.Open();
                    serial.DiscardInBuffer();
                    bldc.GetFwVersion();
                    Thread.Sleep(250);
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
            try
            {
                serial.DtrEnable = false;
                serial.RtsEnable = false;
                serial.DataReceived -= Serial_DataReceived;
                serial.ErrorReceived -= Serial_ErrorReceived;
                Thread.Sleep(250);
                if (serial.IsOpen == true)
                {
                    serial.DiscardInBuffer();
                    serial.DiscardOutBuffer();
                    serial.Close();
                }
                init = false;
                connected = false;
                ConnectionChanged?.Invoke(this, connected);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
