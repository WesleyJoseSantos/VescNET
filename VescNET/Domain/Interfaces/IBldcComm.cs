using System;
using VescNET.Domain.DTOs;

namespace VescNET.Domain.Interfaces
{
    public interface IBldcComm
    {
        void Send(IBuffer buffer);
        event EventHandler<ReceivedData> OnData;
    }
}
