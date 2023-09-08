using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class BalanceConfig
    {
        public BalancePidMode PidMode { get; set; }
        public float Kp { get; set; }
        public float Ki { get; set; }
        public float Kd { get; set; }
        public float Kp2 { get; set; }
        public float Ki2 { get; set; }
        public float Kd2 { get; set; }
        public ushort Hertz { get; set; }
        public ushort LoopTimeFilter { get; set; }
        public float FaultPitch { get; set; }
        public float FaultRoll { get; set; }
        public float FaultDuty { get; set; }
        public float FaultAdc1 { get; set; }
        public float FaultAdc2 { get; set; }
        public ushort FaultDelayPitch { get; set; }
        public ushort FaultDelayRoll { get; set; }
        public ushort FaultDelayDuty { get; set; }
        public ushort FaultDelaySwitchHalf { get; set; }
        public ushort FaultDelaySwitchFull { get; set; }
        public ushort FaultAdcHalfErpm { get; set; }
        public bool FaultIsDualSwitch { get; set; }
        public float TiltbackDutyAngle { get; set; }
        public float TiltbackDutySpeed { get; set; }
        public float TiltbackDuty { get; set; }
        public float TiltbackHvAngle { get; set; }
        public float TiltbackHvSpeed { get; set; }
        public float TiltbackHv { get; set; }
        public float TiltbackLvAngle { get; set; }
        public float TiltbackLvSpeed { get; set; }
        public float TiltbackLv { get; set; }
        public float TiltbackReturnSpeed { get; set; }
        public float TiltbackConstant { get; set; }
        public ushort TiltbackConstantErpm { get; set; }
        public float TiltbackVariable { get; set; }
        public float TiltbackVariableMax { get; set; }
        public float NoseanglingSpeed { get; set; }
        public float StartupPitchTolerance { get; set; }
        public float StartupRollTolerance { get; set; }
        public float StartupSpeed { get; set; }
        public float Deadzone { get; set; }
        public bool MultiEsc { get; set; }
        public float YawKp { get; set; }
        public float YawKi { get; set; }
        public float YawKd { get; set; }
        public float RollSteerKp { get; set; }
        public float RollSteerErpmKp { get; set; }
        public float BrakeCurrent { get; set; }
        public ushort BrakeTimeout { get; set; }
        public float YawCurrentClamp { get; set; }
        public float KiLimit { get; set; }
        public ushort KdPt1LowpassFrequency { get; set; }
        public ushort KdPt1HighpassFrequency { get; set; }
        public float KdBiquadLowpass { get; set; }
        public float KdBiquadHighpass { get; set; }
        public float BoosterAngle { get; set; }
        public float BoosterRamp { get; set; }
        public float BoosterCurrent { get; set; }
        public float TorqueTiltStartCurrent { get; set; }
        public float TorqueTiltAngleLimit { get; set; }
        public float TorqueTiltOnSpeed { get; set; }
        public float TorqueTiltOffSpeed { get; set; }
        public float TorqueTiltStrength { get; set; }
        public float TorqueTiltFilter { get; set; }
        public float TurnTiltStrength { get; set; }
        public float TurnTiltAngleLimit { get; set; }
        public float TurnTiltStartAngle { get; set; }
        public ushort TurnTiltStartErpm { get; set; }
        public float TurnTiltSpeed { get; set; }
        public ushort TurnTiltErpmBoost { get; set; }
        public ushort TurnTiltErpmBoostEnd { get; set; }
    }
}
