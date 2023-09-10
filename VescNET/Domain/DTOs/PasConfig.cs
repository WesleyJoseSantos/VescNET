using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class PasConfig
    {
        public PasControlType CtrlType { get; set; }
        public PasSensorType SensorType { get; set; }
        public float CurrentScaling { get; set; }
        public float PedalRpmStart { get; set; }
        public float PedalRpmEnd { get; set; }
        public bool InvertPedalDirection { get; set; }
        public ushort Magnets { get; set; }
        public bool UseFilter { get; set; }
        public float RampTimePos { get; set; }
        public float RampTimeNeg { get; set; }
        public ushort UpdateRateHz { get; set; }
    }
}
