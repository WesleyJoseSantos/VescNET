using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;

namespace VescNET.Domain.Interfaces
{
    public interface IPacket
    {
        byte[] Tx { get; }
        byte[] Rx { get; }
        ReceivedData ReceivedData { get; }
        PacketProcessState ProcessRX(byte @byte);
        void ProcessTX(byte[] data);
    }
}
