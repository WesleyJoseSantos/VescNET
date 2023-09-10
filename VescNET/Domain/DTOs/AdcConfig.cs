using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class AdcConfig
    {
        public AdcControlType CtrlType { get; set; }
        public float Hyst { get; set; }
        public float VoltageStart { get; set; }
        public float VoltageEnd { get; set; }
        public float VoltageCenter { get; set; }
        public float Voltage2Start { get; set; }
        public float Voltage2End { get; set; }
        public bool UseFilter { get; set; }
        public bool SafeStart { get; set; }
        public bool CcButtonInverted { get; set; }
        public bool RevButtonInverted { get; set; }
        public bool VoltageInverted { get; set; }
        public bool Voltage2Inverted { get; set; }
        public float ThrottleExp { get; set; }
        public float ThrottleExpBrake { get; set; }
        public ThrExpMode ThrottleExpMode { get; set; }
        public float RampTimePos { get; set; }
        public float RampTimeNeg { get; set; }
        public bool MultiEsc { get; set; }
        public bool Tc { get; set; }
        public float TcMaxDiff { get; set; }
        public ushort UpdateRateHz { get; set; }
    }
}
