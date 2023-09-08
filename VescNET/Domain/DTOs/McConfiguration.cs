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
        public float LCurrentMaxScale { get; set; }
        public float LCurrentMinScale { get; set; }
        public float LDutyStart { get; set; }
        //public float LoInCurrentMax { get; set; }
        //public float LoInCurrentMin { get; set; }
        //public float LoCurrentMotorMaxNow { get; set; }
        //public float LoCurrentMotorMinNow { get; set; }

        // Sensorless (bldc)
        public float SlMinErpm { get; set; }
        public float SlMinErpmCycleIntLimit { get; set; }
        public float SlMaxFullbreakCurrentDirChange { get; set; }
        public float SlCycleIntLimit { get; set; }
        public float SlPhaseAdvanceAtBr { get; set; }
        public float SlCycleIntRpmBr { get; set; }
        public float SlBemfCouplingK { get; set; }

        // Hall sensor
        public byte[] HallTable { get; set; }
        public float HallSlErpm { get; set; }

        // FOC
        public float FocCurrentKp { get; set; }
        public float FocCurrentKi { get; set; }
        public float FocFSw { get; set; }
        public float FocDtUs { get; set; }
        public float FocEncoderOffset { get; set; }
        public bool FocEncoderInverted { get; set; }
        public float FocEncoderRatio { get; set; }
        public float FocEncoderSinGain{ get; set; }
        public float FocEncoderCosGain { get; set; }
        public float FocEncoderSinOffset { get; set; }
        public float FocEncoderCosOfset { get; set; }
        public float FocEncoderSinCosFilterConstant { get; set; }
        public float FocMotorL { get; set; }
        public float FocMotorLdLqDiff { get; set; }
        public float FocMotorR { get; set; }
        public float FocMotorFluxLinkage { get; set; }
        public float FocObserverGain { get; set; }
        public float FocObserverGainSlow { get; set; }
        public float FocObserverOffset { get; set; }
        public float FocSpeedTrackerKp { get; set; }
        public float FocSpeedTrackerKi { get; set; }
        public float FocDutyDowmrampKp { get; set; }
        public float FocDutyDowmrampKi { get; set; }
        public float FocOpenloopRpm { get; set; }
        public float FocOpenloopRpmLow { get; set; }
        public float FocDGainScaleStart { get; set; }
        public float FocDGainScaleMaxMod { get; set; }
        public float FocSlOpenloopHyst { get; set; }
        public float FocSlOpenloopTimeLock { get; set; }
        public float FocSlOpenloopTimeRamp { get; set; }
        public float FocSlOpenloopTime { get; set; }
        public McFocSensorMode FocSensorMode { get; set; }
        public byte[] FocHallTable { get; set; }
        public float FocHallInterpErpm { get; set; }
        public float FocSlErpm { get; set; }
        public bool FocSampleV0V7 { get; set; }
        public bool FocSampleHighCurrent { get; set; }
        public float FocSatComp { get; set; }
        public bool FocTempComp { get; set; }
        public float FocTempCompBaseTemp { get; set; }
        public float FocCurrentFilterConst { get; set; }
        public byte FocCcDecoupling { get; set; }
        public byte FocObserverType { get; set; }
        public float FocHfiVoltageStart { get; set; }
        public float FocHfiVoltageRun { get; set; }
        public float FocHfiVoltageMax { get; set; }
        public float FocHfiGain { get; set; }
        public float FocHfiHyst { get; set; }
        public float FocSlErpmHfi { get; set; }
        public float FocHfiStartSamples { get; set; }
        public float FocHfiObsOvrSec { get; set; }
        public byte FocHfiSamples { get; set; }
        public byte FocOffsetsCalOnBoot { get; set; }
        public float[] FocOffsetsCurrent { get; set; }
        public float[] FocOffsetsVoltage { get; set; }
        public float[] FocOffsetsVoltageUndriven { get; set; }
        public bool FocPhaseFilterEnable { get; set; }
        //public bool FocPhaseFilterDisableFault { get; set; }
        public float FocPhaseFilterMaxErpm { get; set; }
        public byte FocMtpaMode { get; set; }
        public float FocFwCurrentMax { get; set; }
        public float FocFwDutyStart { get; set; }
        public float FocFwRampTime { get; set; }
        public float FocFwQCurrentFactor { get; set; }
        public byte FocSpeedSoure { get; set; }

        // Speed PID
        public byte SPidLoopRate { get; set; }
        public float SPidKp { get; set; }
        public float SPidKi { get; set; }
        public float SPidKd { get; set; }
        public float SPidKdFilter { get; set; }
        public float SPidMinErpm { get; set; }
        public bool SPidAllowBraking { get; set; }
        public float SPidRampErpmsS { get; set; }

        // GPDrive
        public int GpdBufferNotifyLeft { get; set; }
        public int GpdBufferInterpol { get; set; }
        public float GpdCurrentFilterConst { get; set; }
        public float GpdCurrentKp { get; set; }
        public float GpdCurrentKi { get; set; }

        // Pos PID
        public float PPidKp { get; set; }
        public float PPidKi { get; set; }
        public float PPidKd { get; set; }
        public float PPidKdProc { get; set; }
        public float PPidKdFilter { get; set; }
        public float PPidAngDiv { get; set; }
        public float PPidGainDecAngle { get; set; }
        public float PPidOffset { get; set; }

        // Current controller
        public float CcStartupBoostDuty { get; set; }
        public float CcMinCurrent { get; set; }
        public float CcControllerGain { get; set; }
        public float CcRampStepMax { get; set; }

        // Misc
        public int MFaultStopTimeMs { get; set; }
        public float MDutyRampStep {get; set;}
        public float MCurrentBackoffGain {get; set;}
        public uint MEncoderCounts {get; set;}
        public float MEncoderSinOffset {get; set;}
        public float MEncoderSinAmp {get; set;}
        public float MEncoderCosOffset {get; set;}
        public float MEncoderCosAmp {get; set;}
        public float MEncoderSincosFilterConstant {get; set;}
        public float MEncoderSincosPhaseCorrection {get; set;}
        public SensorPortMode MSensorPortMode {get; set;}
        public bool MInvertDirection {get; set;}
        public Drv8301OcMode MDrv8301OcMode {get; set;}
        public int MDrv8301OcAdj {get; set;}
        public float MBldcFSwMin {get; set;}
        public float MBldcFSwMax {get; set;}
        public float MDcFSw {get; set;}
        public float MNtcMotorBeta {get; set;}
        public OutAuxMode MOutAuxMode {get; set;}
        public TempSensorType MMotorTempSensType {get; set;}
        public float MPtcMotorCoeff {get; set;}
        public int MHallExtraSamples {get; set;}
        public int MBattFilterConst {get; set;}
        public float MNtcxPtcxTempBase {get; set;}
        public float MNtcxPtcxRes {get; set;}

        // Setup info
        public byte SiMotorPoles {get; set;}
        public float SiGearRatio {get; set;}
        public float SiWheelDiameter {get; set;}
        public BatteryType SiBatteryType {get; set;}
        public int SiBatteryCells {get; set;}
        public float SiBatteryAh {get; set;}
        public float SiMotorNlCurrent {get; set;}

        public BmsConfig Bms {get; set;}

        public McConfiguration()
        {
            Bms = new BmsConfig();
        }
    }
}
