using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class ReceivedData
    {
        public CommPacketId PacketId { get; set; }
        public object Data { get; set; }
    }
}
