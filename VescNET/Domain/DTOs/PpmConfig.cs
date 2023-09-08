using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class PpmConfig
    {
        public PpmControlType CtrlType { get; set; }
        public float PidMaxErpm { get; set; }
        public float Hyst { get; set; }
        public float PulseStart { get; set; }
        public float PulseEnd { get; set; }
        public float PulseCenter { get; set; }
        public bool MedianFilter { get; set; }
        public byte SafeStart { get; set; }
        public float ThrottleExp { get; set; }
        public float ThrottleExpBrake { get; set; }
        public ThrExpMode ThrottleExpMode { get; set; }
        public float RampTimePos { get; set; }
        public float RampTimeNeg { get; set; }
        public bool MultiEsc { get; set; }
        public bool Tc { get; set; }
        public float TcMaxDiff { get; set; }
        public float MaxErpmForDir { get; set; }
        public float SmartRevMaxDuty { get; set; }
        public float SmartRevRamptime { get; set; }
    }
}
