using System;
using VescNET.Domain.DTOs;

namespace VescNET.Domain.Interfaces
{
    public interface IBldcComm
    {
        bool Connected { get; }
        event EventHandler<ReceivedData> OnData;
        event EventHandler<bool> ConnectionChanged;
        void Send(IBuffer buffer);
        bool Connect(IBldc bldc);
        void Disconnect();
    }
}
