namespace VescNET.Domain.DTOs
{
    public class UavCanConfig
    {
        public byte EscIndex { get; set; }
        public byte RawThrottleMode { get; set; }
        public float RawRpmMax { get; set; }
        public byte StatusCurrentMode { get; set; }
    }
}
