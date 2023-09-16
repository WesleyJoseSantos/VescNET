using System;
using System.Net;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class Bldc : IBldc
    {
        private readonly IBuffer buffer;
        private readonly IBldcComm comm;

        public bool Connected => comm.Connected;

        public Bldc(IBuffer buffer, IBldcComm comm)
        {
            this.buffer = buffer;
            this.comm = comm;
        }

        public void GetAppconf()
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.GetAppConf);
            comm.Send(buffer);
        }

        public void GetAppconfDefault()
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.GetAppConfDefault);
            comm.Send(buffer);
        }

        public void GetFwVersion()
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.FwVersion);
            comm.Send(buffer);
        }

        public void GetMcconf()
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.GetMcConf);
            comm.Send(buffer);
        }

        public void GetMcconfDefault()
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.GetMcConfDefault);
            comm.Send(buffer);
        }

        public void GetValues()
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.GetValues);
            comm.Send(buffer);
        }

        public void SetAppconf(AppConfiguration appconf)
        {
            buffer.Clear();

            buffer.AppendData(CommPacketId.SetMcConf);
            buffer.AppendData(PacketProcess.AppConfSignature);

            buffer.AppendData(appconf.ControllerId);
            buffer.AppendData(appconf.TimeoutMsec);
            buffer.AppendData(appconf.TimeoutBrakeCurrent);

            buffer.AppendData(appconf.CanConfig.StatusMessageMode);
            buffer.AppendData(appconf.CanConfig.StatusRateHz);
            buffer.AppendData(appconf.CanConfig.BaudRate);

            buffer.AppendData(appconf.PairingDone);
            buffer.AppendData(appconf.EnablePermanentUart);
            buffer.AppendData(appconf.ShutdownMode);

            buffer.AppendData(appconf.CanConfig.CanMode);
            buffer.AppendData(appconf.CanConfig.Uav.EscIndex);
            buffer.AppendData(appconf.CanConfig.Uav.RawThrottleMode);
            buffer.AppendData(appconf.CanConfig.Uav.RawRpmMax);

            buffer.AppendData(appconf.ServoOutEnabled);
            buffer.AppendData(appconf.KillSwitchMode);

            buffer.AppendData(appconf.AppToUse);

            buffer.AppendData(appconf.PpmConf.CtrlType);
            buffer.AppendData(appconf.PpmConf.PidMaxErpm);
            buffer.AppendData(appconf.PpmConf.Hyst);
            buffer.AppendData(appconf.PpmConf.PulseStart);
            buffer.AppendData(appconf.PpmConf.PulseEnd);
            buffer.AppendData(appconf.PpmConf.PulseCenter);
            buffer.AppendData(appconf.PpmConf.MedianFilter);
            buffer.AppendData(appconf.PpmConf.SafeStart);
            buffer.AppendData(appconf.PpmConf.ThrottleExp);
            buffer.AppendData(appconf.PpmConf.ThrottleExpBrake);
            buffer.AppendData(appconf.PpmConf.ThrottleExpMode);
            buffer.AppendData(appconf.PpmConf.RampTimePos);
            buffer.AppendData(appconf.PpmConf.RampTimeNeg);
            buffer.AppendData(appconf.PpmConf.MultiEsc);
            buffer.AppendData(appconf.PpmConf.Tc);
            buffer.AppendData(appconf.PpmConf.TcMaxDiff);
            buffer.AppendData(appconf.PpmConf.MaxErpmForDir, 1f, true);
            buffer.AppendData(appconf.PpmConf.SmartRevMaxDuty);
            buffer.AppendData(appconf.PpmConf.SmartRevRamptime);

            buffer.AppendData(appconf.AdcConf.CtrlType);
            buffer.AppendData(appconf.AdcConf.Hyst);
            buffer.AppendData(appconf.AdcConf.VoltageStart);
            buffer.AppendData(appconf.AdcConf.VoltageEnd);
            buffer.AppendData(appconf.AdcConf.VoltageCenter);
            buffer.AppendData(appconf.AdcConf.Voltage2Start);
            buffer.AppendData(appconf.AdcConf.Voltage2End);
            buffer.AppendData(appconf.AdcConf.UseFilter);
            buffer.AppendData(appconf.AdcConf.SafeStart);
            buffer.AppendData(appconf.AdcConf.CcButtonInverted);
            buffer.AppendData(appconf.AdcConf.RevButtonInverted);
            buffer.AppendData(appconf.AdcConf.VoltageInverted);
            buffer.AppendData(appconf.AdcConf.Voltage2Inverted);
            buffer.AppendData(appconf.AdcConf.ThrottleExp);
            buffer.AppendData(appconf.AdcConf.ThrottleExpBrake);
            buffer.AppendData(appconf.AdcConf.ThrottleExpMode);
            buffer.AppendData(appconf.AdcConf.RampTimePos);
            buffer.AppendData(appconf.AdcConf.RampTimeNeg);
            buffer.AppendData(appconf.AdcConf.MultiEsc);
            buffer.AppendData(appconf.AdcConf.Tc);
            buffer.AppendData(appconf.AdcConf.TcMaxDiff);
            buffer.AppendData(appconf.AdcConf.UpdateRateHz);

            buffer.AppendData(appconf.UartBaudrate);

            buffer.AppendData(appconf.ChukConf.CtrlType);
            buffer.AppendData(appconf.ChukConf.Hyst);
            buffer.AppendData(appconf.ChukConf.RampTimePos);
            buffer.AppendData(appconf.ChukConf.RampTimeNeg);
            buffer.AppendData(appconf.ChukConf.StickErpmPerSInCc);
            buffer.AppendData(appconf.ChukConf.ThrottleExp);
            buffer.AppendData(appconf.ChukConf.ThrottleExpBrake);
            buffer.AppendData(appconf.ChukConf.ThrottleExpMode);
            buffer.AppendData(appconf.ChukConf.MultiEsc);
            buffer.AppendData(appconf.ChukConf.Tc);
            buffer.AppendData(appconf.ChukConf.TcMaxDiff);
            buffer.AppendData(appconf.ChukConf.UseSmartRev);
            buffer.AppendData(appconf.ChukConf.SmartRevMaxDuty);
            buffer.AppendData(appconf.ChukConf.SmartRevRamptime);

            buffer.AppendData(appconf.NrfConf.Speed);
            buffer.AppendData(appconf.NrfConf.Power);
            buffer.AppendData(appconf.NrfConf.CrcType);
            buffer.AppendData(appconf.NrfConf.RetryDelay);
            buffer.AppendData(appconf.NrfConf.Retries);
            buffer.AppendData(appconf.NrfConf.Channel);
            buffer.AppendData(appconf.NrfConf.Address, 3);
            // buffer.AppendData( appconf.NrfConf.SendCrcAck);

            buffer.AppendData(appconf.BalanceConf.PidMode);
            buffer.AppendData(appconf.BalanceConf.Kp);
            buffer.AppendData(appconf.BalanceConf.Ki);
            buffer.AppendData(appconf.BalanceConf.Kd);
            // buffer.AppendData(appconf.BalanceConf.Kp2);
            // buffer.AppendData(appconf.BalanceConf.Ki2);
            // buffer.AppendData(appconf.BalanceConf.Kd2);
            buffer.AppendData(appconf.BalanceConf.Hertz);
            buffer.AppendData(appconf.BalanceConf.LoopTimeFilter);
            buffer.AppendData(appconf.BalanceConf.FaultPitch);
            buffer.AppendData(appconf.BalanceConf.FaultRoll);
            buffer.AppendData(appconf.BalanceConf.FaultDuty);
            buffer.AppendData(appconf.BalanceConf.FaultAdc1);
            buffer.AppendData(appconf.BalanceConf.FaultAdc2);
            buffer.AppendData(appconf.BalanceConf.FaultDelayPitch);
            buffer.AppendData(appconf.BalanceConf.FaultDelayRoll);
            buffer.AppendData(appconf.BalanceConf.FaultDelayDuty);
            buffer.AppendData(appconf.BalanceConf.FaultDelaySwitchHalf);
            buffer.AppendData(appconf.BalanceConf.FaultDelaySwitchFull);
            buffer.AppendData(appconf.BalanceConf.FaultAdcHalfErpm);
            // buffer.AppendData(appconf.BalanceConf.FaultIsDualSwitch);
            buffer.AppendData(appconf.BalanceConf.TiltbackDutyAngle, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackDutySpeed, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackDuty, 1000f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackHvAngle, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackHvSpeed, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackHv);
            buffer.AppendData(appconf.BalanceConf.TiltbackLvAngle, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackLvSpeed, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackLv);
            buffer.AppendData(appconf.BalanceConf.TiltbackReturnSpeed, 100f, true);
            buffer.AppendData(appconf.BalanceConf.TiltbackConstant);
            buffer.AppendData(appconf.BalanceConf.TiltbackConstantErpm);
            buffer.AppendData(appconf.BalanceConf.TiltbackVariable);
            buffer.AppendData(appconf.BalanceConf.TiltbackVariableMax);
            buffer.AppendData(appconf.BalanceConf.NoseanglingSpeed, 100f, true);
            buffer.AppendData(appconf.BalanceConf.StartupPitchTolerance);
            buffer.AppendData(appconf.BalanceConf.StartupRollTolerance);
            buffer.AppendData(appconf.BalanceConf.StartupSpeed);
            buffer.AppendData(appconf.BalanceConf.Deadzone);
            buffer.AppendData(appconf.BalanceConf.MultiEsc);
            buffer.AppendData(appconf.BalanceConf.YawKp);
            buffer.AppendData(appconf.BalanceConf.YawKi);
            buffer.AppendData(appconf.BalanceConf.YawKd);
            buffer.AppendData(appconf.BalanceConf.RollSteerKp);
            buffer.AppendData(appconf.BalanceConf.RollSteerErpmKp);
            buffer.AppendData(appconf.BalanceConf.BrakeCurrent);
            buffer.AppendData(appconf.BalanceConf.BrakeTimeout);
            buffer.AppendData(appconf.BalanceConf.YawCurrentClamp);
            // buffer.AppendData(appconf.BalanceConf.KiLimit);
            buffer.AppendData(appconf.BalanceConf.KdPt1LowpassFrequency);
            buffer.AppendData(appconf.BalanceConf.KdPt1HighpassFrequency);
            buffer.AppendData(appconf.BalanceConf.KdBiquadLowpass);
            buffer.AppendData(appconf.BalanceConf.KdBiquadHighpass);
            buffer.AppendData(appconf.BalanceConf.BoosterAngle);
            buffer.AppendData(appconf.BalanceConf.BoosterRamp);
            buffer.AppendData(appconf.BalanceConf.BoosterCurrent);
            buffer.AppendData(appconf.BalanceConf.TorqueTiltStartCurrent);
            buffer.AppendData(appconf.BalanceConf.TorqueTiltAngleLimit);
            buffer.AppendData(appconf.BalanceConf.TorqueTiltOnSpeed);
            buffer.AppendData(appconf.BalanceConf.TorqueTiltOffSpeed);
            buffer.AppendData(appconf.BalanceConf.TorqueTiltStrength);
            buffer.AppendData(appconf.BalanceConf.TorqueTiltFilter);
            buffer.AppendData(appconf.BalanceConf.TurnTiltStrength);
            buffer.AppendData(appconf.BalanceConf.TurnTiltAngleLimit);
            buffer.AppendData(appconf.BalanceConf.TurnTiltStartAngle);
            buffer.AppendData(appconf.BalanceConf.TurnTiltStartErpm);
            buffer.AppendData(appconf.BalanceConf.TurnTiltSpeed);
            buffer.AppendData(appconf.BalanceConf.TurnTiltErpmBoost);
            buffer.AppendData(appconf.BalanceConf.TurnTiltErpmBoostEnd);

            buffer.AppendData(appconf.PasConf.CtrlType);
	        buffer.AppendData(appconf.PasConf.SensorType);
	        buffer.AppendData(appconf.PasConf.CurrentScaling, 1000f, true);
	        buffer.AppendData(appconf.PasConf.PedalRpmStart, 10f, true);
	        buffer.AppendData(appconf.PasConf.PedalRpmEnd, 10f, true);
	        buffer.AppendData(appconf.PasConf.InvertPedalDirection);
	        buffer.AppendData(appconf.PasConf.Magnets);
	        buffer.AppendData(appconf.PasConf.UseFilter);
	        buffer.AppendData(appconf.PasConf.RampTimePos, 100f, true);
	        buffer.AppendData(appconf.PasConf.RampTimeNeg, 100f, true);
	        buffer.AppendData(appconf.PasConf.UpdateRateHz);

            buffer.AppendData(appconf.ImuConf.Type);
            buffer.AppendData(appconf.ImuConf.Mode);
            // buffer.AppendData(appconf.ImuConf.Filter);
            // buffer.AppendHalf(appconf.ImuConf.AccelLowpassFilterX, 1);
            // buffer.AppendHalf(appconf.ImuConf.AccelLowpassFilterY, 1);
            // buffer.AppendHalf(appconf.ImuConf.AccelLowpassFilterZ, 1);
            // buffer.AppendHalf(appconf.ImuConf.GyroLowpassFilter, 1);
            buffer.AppendData(appconf.ImuConf.SampleRateHz);
            // buffer.AppendData(appconf.ImuConf.UseMagnetometer);
            buffer.AppendData(appconf.ImuConf.AccelConfidenceDecay);
            buffer.AppendData(appconf.ImuConf.MahonyKp);
            buffer.AppendData(appconf.ImuConf.MahonyKi);
            buffer.AppendData(appconf.ImuConf.MadgwickBeta);
            buffer.AppendData(appconf.ImuConf.RotRoll);
            buffer.AppendData(appconf.ImuConf.RotPitch);
            buffer.AppendData(appconf.ImuConf.RotYaw);
            buffer.AppendData(appconf.ImuConf.AccelOffsets, 3);
            buffer.AppendData(appconf.ImuConf.GyroOffsets, 3);

            comm.Send(buffer);
        }

        public void SetCurrent(float current)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetCurrent);
            buffer.AppendData(current, 1000.0F);
            comm.Send(buffer);
        }

        public void SetCurrentBrake(float current)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetCurrentBrake);
            buffer.AppendData(current, 1000.0F);
            comm.Send(buffer);
        }

        public void SetDutyCycle(float dutyCycle)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetDuty);
            buffer.AppendData(dutyCycle, 100000);
            comm.Send(buffer);
        }

        public void SetHandbrake(float current)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetHandbrake);
            buffer.AppendData(current, 1E3F);
            comm.Send(buffer);
        }

        public void SetMcconf(McConfiguration mcconf)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetMcConf);
            buffer.AppendData(PacketProcess.McConfSignature);

            buffer.AppendData(mcconf.PwmMode);
            buffer.AppendData(mcconf.CommMode);
            buffer.AppendData(mcconf.MotorType);
            buffer.AppendData(mcconf.SensorMode);

            buffer.AppendData(mcconf.LCurrentMax);
            buffer.AppendData(mcconf.LCurrentMin);
            buffer.AppendData(mcconf.LInCurrentMax);
            buffer.AppendData(mcconf.LInCurrentMin);
            buffer.AppendData(mcconf.LAbsCurrentMax);
            buffer.AppendData(mcconf.LMinErpm);
            buffer.AppendData(mcconf.LMaxErpm);
            buffer.AppendData(mcconf.LErpmStart, 10000f, true);
            buffer.AppendData(mcconf.LMaxErpmFbrake);
            buffer.AppendData(mcconf.LMaxErpmFbrakeCc);
            buffer.AppendData(mcconf.LMinVin);
            buffer.AppendData(mcconf.LMaxVin);
            buffer.AppendData(mcconf.LBatteryCutStart);
            buffer.AppendData(mcconf.LBatteryCutEnd);
            buffer.AppendData(mcconf.LSlowAbsCurrent);
            buffer.AppendData(mcconf.LTempFetStart, 1.0f, true);
            buffer.AppendData(mcconf.LTempFetEnd, 1.0f, true);
            buffer.AppendData(mcconf.LTempMotorStart, 1.0f, true);
            buffer.AppendData(mcconf.LTempMotorEnd, 1.0f, true);
            buffer.AppendData(mcconf.LTempAccelDec, 1.0f, true);
            buffer.AppendData(mcconf.LMinDuty, 1.0f, true);
            buffer.AppendData(mcconf.LMaxDuty, 1.0f, true);
            buffer.AppendData(mcconf.LWattMax);
            buffer.AppendData(mcconf.LWattMin);

            buffer.AppendData(mcconf.LCurrentMaxScale, 10000f, true);
            buffer.AppendData(mcconf.LCurrentMinScale, 10000f, true);
            buffer.AppendData(mcconf.LDutyStart, 10000f, true);

            buffer.AppendData(mcconf.SlMinErpm);
            buffer.AppendData(mcconf.SlMinErpmCycleIntLimit);
            buffer.AppendData(mcconf.SlMaxFullbreakCurrentDirChange);
            buffer.AppendData(mcconf.SlCycleIntLimit, 10f, true);
            buffer.AppendData(mcconf.SlPhaseAdvanceAtBr, 10000f, true);
            buffer.AppendData(mcconf.SlCycleIntRpmBr);
            buffer.AppendData(mcconf.SlBemfCouplingK);

            buffer.AppendData(mcconf.HallTable, 8);

            buffer.AppendData(mcconf.HallSlErpm);
            buffer.AppendData(mcconf.FocCurrentKp);
            buffer.AppendData(mcconf.FocCurrentKi);
            buffer.AppendData(mcconf.FocFSw);
            buffer.AppendData(mcconf.FocDtUs);
            buffer.AppendData(mcconf.FocEncoderInverted);
            buffer.AppendData(mcconf.FocEncoderOffset);
            buffer.AppendData(mcconf.FocEncoderRatio);

            buffer.AppendData(mcconf.FocEncoderSinGain);
            buffer.AppendData(mcconf.FocEncoderCosGain);
            buffer.AppendData(mcconf.FocEncoderSinOffset);
            buffer.AppendData(mcconf.FocEncoderCosOfset);
            buffer.AppendData(mcconf.FocEncoderSinCosFilterConstant);

            buffer.AppendData(mcconf.FocSensorMode);
            buffer.AppendData(mcconf.FocSpeedTrackerKp);
            buffer.AppendData(mcconf.FocSpeedTrackerKi);
            buffer.AppendData(mcconf.FocMotorL);
            buffer.AppendData(mcconf.FocMotorLdLqDiff);
            buffer.AppendData(mcconf.FocMotorR);
            buffer.AppendData(mcconf.FocMotorFluxLinkage);
            buffer.AppendData(mcconf.FocObserverGain);
            buffer.AppendData(mcconf.FocObserverGainSlow);
            buffer.AppendData(mcconf.FocObserverOffset, 1f, true);
            buffer.AppendData(mcconf.FocDutyDowmrampKp);
            buffer.AppendData(mcconf.FocDutyDowmrampKi);
            buffer.AppendData(mcconf.FocOpenloopRpm);
            buffer.AppendData(mcconf.FocOpenloopRpmLow, 1000f, true);
            buffer.AppendData(mcconf.FocDGainScaleStart);
            buffer.AppendData(mcconf.FocDGainScaleMaxMod);
            buffer.AppendData(mcconf.FocSlOpenloopHyst, 100f, true);
            buffer.AppendData(mcconf.FocSlOpenloopTimeLock, 100f, true);
            buffer.AppendData(mcconf.FocSlOpenloopTimeRamp, 100f, true);
            buffer.AppendData(mcconf.FocSlOpenloopTime, 100f, true);

            buffer.AppendData(mcconf.FocHallTable, 8);
            buffer.AppendData(mcconf.FocHallInterpErpm);

            buffer.AppendData(mcconf.FocSlErpm);
            buffer.AppendData(mcconf.FocSampleV0V7);
            buffer.AppendData(mcconf.FocSampleHighCurrent);
            buffer.AppendData(mcconf.FocSatComp, 1000f, true);
            buffer.AppendData(mcconf.FocTempComp);
            buffer.AppendData(mcconf.FocTempCompBaseTemp, 100f, true);
            buffer.AppendData(mcconf.FocCurrentFilterConst, 10000f, true);

            buffer.AppendData(mcconf.FocCcDecoupling);
            buffer.AppendData(mcconf.FocObserverType);
            buffer.AppendData(mcconf.FocHfiVoltageStart);
            buffer.AppendData(mcconf.FocHfiVoltageRun);
            buffer.AppendData(mcconf.FocHfiVoltageMax);
            //buffer.AppendHalf(mcconf.FocHfiGain, 1000f);
            //buffer.AppendHalf(mcconf.FocHfiHyst, 100f);
            buffer.AppendData(mcconf.FocSlErpmHfi);
            buffer.AppendData(mcconf.FocHfiStartSamples);
            buffer.AppendData(mcconf.FocHfiObsOvrSec);
            buffer.AppendData(mcconf.FocHfiSamples);
            buffer.AppendData(mcconf.FocOffsetsCalOnBoot);

            buffer.AppendData(mcconf.FocOffsetsCurrent);
            buffer.AppendData(mcconf.FocOffsetsVoltage, 10000f, true);
            buffer.AppendData(mcconf.FocOffsetsVoltageUndriven, 10000f, true);
            
            buffer.AppendData(mcconf.FocPhaseFilterEnable);
            //buffer.AppendData(mcconf.FocPhaseFilterDisableFault);
            buffer.AppendData(mcconf.FocPhaseFilterMaxErpm);
            buffer.AppendData(mcconf.FocMtpaMode);
            buffer.AppendData(mcconf.FocFwCurrentMax);
            buffer.AppendData(mcconf.FocFwDutyStart, 10000f, true);
            buffer.AppendData(mcconf.FocFwRampTime, 1000f, true);
            buffer.AppendData(mcconf.FocFwQCurrentFactor, 10000f, true);
            //buffer.AppendData(mcconf.FocSpeedSoure);

            buffer.AppendData(mcconf.GpdBufferNotifyLeft);
            buffer.AppendData(mcconf.GpdBufferInterpol);
            buffer.AppendData(mcconf.GpdCurrentFilterConst, 10000f, true);
            buffer.AppendData(mcconf.GpdCurrentKp);
            buffer.AppendData(mcconf.GpdCurrentKi);

            buffer.AppendData(mcconf.SPidLoopRate);
            buffer.AppendData(mcconf.SPidKp);
            buffer.AppendData(mcconf.SPidKi);
            buffer.AppendData(mcconf.SPidKd);
            buffer.AppendData(mcconf.SPidKdFilter, 10000f, true);
            buffer.AppendData(mcconf.SPidMinErpm);
            buffer.AppendData(mcconf.SPidAllowBraking);
            buffer.AppendData(mcconf.SPidRampErpmsS);

            buffer.AppendData(mcconf.PPidKp);
            buffer.AppendData(mcconf.PPidKi);
            buffer.AppendData(mcconf.PPidKd);
            buffer.AppendData(mcconf.PPidKdProc);
            buffer.AppendData(mcconf.PPidKdFilter);
            buffer.AppendData(mcconf.PPidAngDiv);
            buffer.AppendData(mcconf.PPidGainDecAngle, 10f, true);
            buffer.AppendData(mcconf.PPidOffset);

            buffer.AppendData(mcconf.CcStartupBoostDuty);
            buffer.AppendData(mcconf.CcMinCurrent);
            buffer.AppendData(mcconf.CcControllerGain);
            buffer.AppendData(mcconf.CcRampStepMax);

            buffer.AppendData(mcconf.MFaultStopTimeMs);
            buffer.AppendData(mcconf.MDutyRampStep);
            buffer.AppendData(mcconf.MCurrentBackoffGain);
            buffer.AppendData(mcconf.MEncoderCounts);
            //buffer.AppendHalf(mcconf.MEncoderSinAmp, 1000f);
            //buffer.AppendHalf(mcconf.MEncoderCosAmp, 1000f);
            //buffer.AppendHalf(mcconf.MEncoderSinOffset, 1000f);
            //buffer.AppendHalf(mcconf.MEncoderCosOffset, 1000f);
            //buffer.AppendHalf(mcconf.MEncoderSincosFilterConstant, 1000f);
            //buffer.AppendHalf(mcconf.MEncoderSincosPhaseCorrection, 1000f);
            buffer.AppendData(mcconf.MSensorPortMode);
            buffer.AppendData(mcconf.MInvertDirection);
            buffer.AppendData(mcconf.MDrv8301OcMode);
            buffer.AppendData(mcconf.MDrv8301OcAdj);
            buffer.AppendData(mcconf.MBldcFSwMin);
            buffer.AppendData(mcconf.MBldcFSwMax);
            buffer.AppendData(mcconf.MDcFSw);
            buffer.AppendData(mcconf.MNtcMotorBeta);
            buffer.AppendData(mcconf.MOutAuxMode);
            buffer.AppendData(mcconf.MMotorTempSensType);
            buffer.AppendData(mcconf.MPtcMotorCoeff);
            buffer.AppendData(mcconf.MNtcxPtcxRes, 0f, true);
            buffer.AppendData(mcconf.MNtcxPtcxTempBase, 10f, true);
            buffer.AppendData(mcconf.MHallExtraSamples);
            //buffer.AppendData(mcconf.MBattFilterConst);

            buffer.AppendData(mcconf.SiMotorPoles);
            buffer.AppendData(mcconf.SiGearRatio);
            buffer.AppendData(mcconf.SiWheelDiameter);
            buffer.AppendData(mcconf.SiBatteryType);
            buffer.AppendData(mcconf.SiBatteryCells);
            buffer.AppendData(mcconf.SiBatteryAh);
            buffer.AppendData(mcconf.SiMotorNlCurrent);
            
            buffer.AppendData(mcconf.Bms.Type);
            //buffer.AppendData(mcconf.Bms.LimitMode);
            buffer.AppendData(mcconf.Bms.TLimitStart, 100f, true);
            buffer.AppendData(mcconf.Bms.TLimitEnd, 100f, true);
            buffer.AppendData(mcconf.Bms.SocLimitStart, 1000f, true);
            buffer.AppendData(mcconf.Bms.SocLimitEnd, 1000f, true);
            buffer.AppendData(mcconf.Bms.FwdCanMode);


            
            comm.Send(buffer);
        }

        public void SetPos(float pos)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetPos);
            buffer.AppendData(pos, 1000000.0F);
            comm.Send(buffer);
        }

        public void SetRpm(int rpm)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetRpm);
            buffer.AppendData(rpm);
            comm.Send(buffer);
        }

        public void SetServoPos(float pos)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.SetServoPos);
            buffer.AppendData(pos, 1000.0F);
            comm.Send(buffer);
        }

        public void DetectEncoder(float current)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.DetectEncoder);
            buffer.AppendData(current, 1e3f);
            comm.Send(buffer);
        }

        public void TerminalCmd(string cmd)
        {
            buffer.Clear();
            buffer.AppendData(CommPacketId.TerminalCmd);
            buffer.AppendData(cmd);
            comm.Send(buffer);
        }
    }
}
