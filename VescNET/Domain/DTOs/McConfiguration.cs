using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class McConfiguration
    {
        // Switching and drive
        public McPwmMode PwmMode { get; set; }
        public McCommMode CommMode { get; set; }
        public McMotorType MotorType { get; set; }
        public McSensorMode SensorMode { get; set; }

        // Limits
        public float LCurrentMax { get; set; }
        public float LCurrentMin { get; set; }
        public float LInCurrentMax { get; set; }
        public float LInCurrentMin { get; set; }
        public float LAbsCurrentMax { get; set; }
        public float LMinErpm { get; set; }
        public float LMaxErpm { get; set; }
        public float LErpmStart { get; set; }
        public float LMaxErpmFbrake { get; set; }
        public float LMaxErpmFbrakeCc { get; set; }
        public float LMinVin { get; set; }
        public float LMaxVin { get; set; }
        public float LBatteryCutStart { get; set; }
        public float LBatteryCutEnd { get; set; }
        public bool LSlowAbsCurrent { get; set; }
        public float LTempFetStart { get; set; }
        public float LTempFetEnd { get; set; }
        public float LTempMotorStart { get; set; }
        public float LTempMotorEnd { get; set; }
        public float LTempAccelDec { get; set; }
        public float LMinDuty { get; set; }
        public float LMaxDuty { get; set; }
        public float LWattMax { get; set; }
        public float LWattMin { get; set; }

        // Overridden limits (Computed during runtime)
        public float LoCurrentMax { get; set; }
        public float LoCurrentMin { get; set; }
        public float LoInCurrentMax { get; set; }
        public float LoInCurrentMin { get; set; }
        public float LoCurrentMotorMaxNow { get; set; }
        public float LoCurrentMotorMinNow { get; set; }

        // Sensorless (bldc)
        public float SlMinErpm { get; set; }
        public float SlMinErpmCycleIntLimit { get; set; }
        public float SlMaxFullbreakCurrentDirChange { get; set; }
        public float SlCycleIntLimit { get; set; }
        public float SlPhaseAdvanceAtBr { get; set; }
        public float SlCycleIntRpmBr { get; set; }
        public float SlBemfCouplingK { get; set; }

        // Hall sensor
        public sbyte[] HallTable { get; set; }
        public float HallSlErpm { get; set; }

        // FOC
        public float FocCurrentKp { get; set; }
        public float FocCurrentKi { get; set; }
        public float FocFSw { get; set; }
        public float FocDtUs { get; set; }
        public float FocEncoderOffset { get; set; }
        public bool FocEncoderInverted { get; set; }
        public float FocEncoderRatio { get; set; }
        public float FocMotorL { get; set; }
        public float FocMotorR { get; set; }
        public float FocMotorFluxLinkage { get; set; }
        public float FocObserverGain { get; set; }
        public float FocObserverGainSlow { get; set; }
        public float FocPllKp { get; set; }
        public float FocPllKi { get; set; }
        public float FocDutyDowmrampKp { get; set; }
        public float FocDutyDowmrampKi { get; set; }
        public float FocOpenloopRpm { get; set; }
        public float FocSlOpenloopHyst { get; set; }
        public float FocSlOpenloopTime { get; set; }
        public float FocSlDCurrentDuty { get; set; }
        public float FocSlDCurrentFactor { get; set; }
        public McFocSensorMode FocSensorMode { get; set; }
        public byte[] FocHallTable { get; set; }
        public float FocSlErpm { get; set; }
        public bool FocSampleV0V7 { get; set; }
        public bool FocSampleHighCurrent { get; set; }
        public float FocSatComp { get; set; }
        public bool FocTempComp { get; set; }
        public float FocTempCompBaseTemp { get; set; }
        public float FocCurrentFilterConst { get; set; }

        // Speed PID
        public float SPidKp { get; set; }
        public float SPidKi { get; set; }
        public float SPidKd { get; set; }
        public float SPidKdFilter { get; set; }
        public float SPidMinErpm { get; set; }
        public bool SPidAllowBraking { get; set; }

        // Pos PID
        public float PPidKp { get; set; }
        public float PPidKi { get; set; }
        public float PPidKd { get; set; }
        public float PPidKdFilter { get; set; }
        public float PPidAngDiv { get; set; }

        // Current controller
        public float CcStartupBoostDuty { get; set; }
        public float CcMinCurrent { get; set; }
        public float CcGain { get; set; }
        public float CcRampStepMax { get; set; }

        // Misc
        public int MFaultStopTimeMs { get; set; }
        public float MDutyRampStep { get; set; }
        public float MCurrentBackoffGain { get; set; }
        public uint MEncoderCounts { get; set; }
        public SensorPortMode MSensorPortMode { get; set; }
        public bool MInvertDirection { get; set; }
        public Drv8301OcMode MDrv8301OcMode { get; set; }
        public int MDrv8301OcAdj { get; set; }
        public float MBldcFSwMin { get; set; }
        public float MBldcFSwMax { get; set; }
        public float MDcFSw { get; set; }
        public float MNtcMotorBeta { get; set; }
        public OutAuxMode MOutAuxMode { get; set; }
    }
}
