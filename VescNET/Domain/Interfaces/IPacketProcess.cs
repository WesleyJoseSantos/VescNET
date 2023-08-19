using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.DTOs;

namespace VescNET.Domain.Interfaces
{
    public interface IPacketProcess
    {
        ReceivedData Call(IBuffer buffer, uint payloadLength);
    }
}
