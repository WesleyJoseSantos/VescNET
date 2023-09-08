using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class ImuConfig
    {
        public ImuType Type { get; set; }
        public AhrsMode Mode { get; set; }
        public ImuFilter Filter { get; set; }
        public float AccelLowpassFilterX { get; set; }
        public float AccelLowpassFilterY { get; set; }
        public float AccelLowpassFilterZ { get; set; }
        public float GyroLowpassFilter { get; set; }
        public int SampleRateHz { get; set; }
        public bool UseMagnetometer { get; set; }
        public float AccelConfidenceDecay { get; set; }
        public float MahonyKp { get; set; }
        public float MahonyKi { get; set; }
        public float MadgwickBeta { get; set; }
        public float RotRoll { get; set; }
        public float RotPitch { get; set; }
        public float RotYaw { get; set; }
        public float[] AccelOffsets { get; set; }
        public float[] GyroOffsets { get; set; }
    }
}
