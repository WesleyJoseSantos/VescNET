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
        ReceivedData ReceivedData { get; }
        PacketProcessState ProcessRX(byte @byte);
        byte[] ProcessTX(byte[] data);
    }
}
