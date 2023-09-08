using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class ChukConfig
    {
        public ChukControlType CtrlType { get; set; }
        public float Hyst { get; set; }
        public float RampTimePos { get; set; }
        public float RampTimeNeg { get; set; }
        public float StickErpmPerSInCc { get; set; }
        public float ThrottleExp { get; set; }
        public float ThrottleExpBrake { get; set; }
        public ThrExpMode ThrottleExpMode { get; set; }
        public bool MultiEsc { get; set; }
        public bool Tc { get; set; }
        public float TcMaxDiff { get; set; }
        public bool UseSmartRev { get; set; }
        public float SmartRevMaxDuty { get; set; }
        public float SmartRevRamptime { get; set; }
    }

}
