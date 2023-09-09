﻿using System;
using System.IO.Ports;
using VescNET.Domain.DTOs;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class BldcSerial : IBldcComm
    {
        private readonly IPacket packet;

        private readonly SerialPort serial;

        public bool Connected => serial.IsOpen;

        public event EventHandler<ReceivedData> OnData;

        public BldcSerial(IPacket packet, SerialPort serial)
        {
            this.packet = packet;
            this.serial = serial;
            this.serial.DataReceived += Serial_DataReceived;
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            while (serial.BytesToRead != 0)
            {
                var result = packet.ProcessRX((byte)serial.ReadByte());
                if(result == Domain.Enums.PacketProcessState.Done) 
                {
                    OnData?.Invoke(this, packet.ReceivedData);
                }
            }
        }

        public void Send(IBuffer buffer)
        {
            if(Connected)
            {
                var result = packet.ProcessTX(buffer.Data);
                serial.Write(result, 0, result.Length);
            }
        }
    }
}
