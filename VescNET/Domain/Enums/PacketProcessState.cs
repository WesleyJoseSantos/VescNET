namespace VescNET.Domain.Enums
{
    public enum PacketProcessState
    {
        Error=-1,
        Idle = 0,
        Processing,
        Timeout,
        Done,
    }
}
