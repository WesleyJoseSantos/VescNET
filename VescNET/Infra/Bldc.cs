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

        public Bldc(IBuffer buffer, IBldcComm comm)
        {
            this.buffer = buffer;
            this.comm = comm;
        }

        public void GetAppconf()
        {
            buffer.AppendData(CommPacketId.GetAppConf);
            comm.Send(buffer);
        }

        public void GetDecodedAdc()
        {
            buffer.AppendData(CommPacketId.GetDecodedAdc);
            comm.Send(buffer);
        }

        public void GetDecodedChuk()
        {
            buffer.AppendData(CommPacketId.GetDecodedChuk);
            comm.Send(buffer);
        }

        public void GetDecodedPpm()
        {
            buffer.AppendData(CommPacketId.GetDecodedPpm); 
            comm.Send(buffer);
        }

        public void GetFwVersion()
        {
            buffer.AppendData(CommPacketId.FwVersion); 
            comm.Send(buffer);
        }

        public void GetMcconf()
        {
            buffer.AppendData(CommPacketId.GetMcConf);
            comm.Send(buffer);
        }

        public void GetValues()
        {
            buffer.AppendData(CommPacketId.GetValues);
            comm.Send(buffer);
        }

        public void SetAppconf(AppConfiguration appconf)
        {
            buffer.AppendData(CommPacketId.SetAppConf);
            buffer.AppendData(appconf.ControllerId);
            buffer.AppendData(appconf.TimeoutMsec);
            buffer.AppendData(appconf.TimeoutBrakeCurrent);
            buffer.AppendData(appconf.SendCanStatus);
            buffer.AppendData(appconf.SendCanStatusRateHz);
            buffer.AppendData(appconf.CanBaudRate);
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

            buffer.AppendData(appconf.NrfConf.Speed);
            buffer.AppendData(appconf.NrfConf.Power);
            buffer.AppendData(appconf.NrfConf.CrcType);
            buffer.AppendData(appconf.NrfConf.RetryDelay);
            buffer.AppendData(appconf.NrfConf.Retries);
            buffer.AppendData(appconf.NrfConf.Channel);
            buffer.AppendData(appconf.NrfConf.Address);
            buffer.AppendData(appconf.NrfConf.SendCrcAck);

            comm.Send(buffer);
        }

        public void SetCurrent(float current)
        {
            buffer.AppendData(CommPacketId.SetCurrent);
            buffer.AppendData(current, 1000.0F);
            comm.Send(buffer);
        }

        public void SetCurrentBrake(float current)
        {
            buffer.AppendData(CommPacketId.SetCurrentBrake);
            buffer.AppendData(current, 1000.0F);
            comm.Send(buffer);
        }

        public void SetDutyCycle(float dutyCycle)
        {
            buffer.AppendData(CommPacketId.SetDuty);
            buffer.AppendData(dutyCycle, 100000);
            comm.Send(buffer);
        }

        public void SetHandbrake(float current)
        {
            buffer.AppendData(CommPacketId.SetHandbrake);
            buffer.AppendData(current, 1E3F);
            comm.Send(buffer);
        }

        public void SetMcconf(McConfiguration mcconf)
        {
            buffer.AppendData(CommPacketId.SetMcConf);
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
            buffer.AppendData(mcconf.LErpmStart);
            buffer.AppendData(mcconf.LMaxErpmFbrake);
            buffer.AppendData(mcconf.LMaxErpmFbrakeCc);
            buffer.AppendData(mcconf.LMinVin);
            buffer.AppendData(mcconf.LMaxVin);
            buffer.AppendData(mcconf.LBatteryCutStart);
            buffer.AppendData(mcconf.LBatteryCutEnd);
            buffer.AppendData(mcconf.LSlowAbsCurrent);
            buffer.AppendData(mcconf.LTempFetStart);
            buffer.AppendData(mcconf.LTempFetEnd);
            buffer.AppendData(mcconf.LTempMotorStart);
            buffer.AppendData(mcconf.LTempMotorEnd);
            buffer.AppendData(mcconf.LTempAccelDec);
            buffer.AppendData(mcconf.LMinDuty);
            buffer.AppendData(mcconf.LMaxDuty);
            buffer.AppendData(mcconf.LWattMax);
            buffer.AppendData(mcconf.LWattMin);
            buffer.AppendData(mcconf.LoCurrentMax);
            buffer.AppendData(mcconf.LoCurrentMin);
            buffer.AppendData(mcconf.LoInCurrentMax);
            buffer.AppendData(mcconf.LoInCurrentMin);
            buffer.AppendData(mcconf.LoCurrentMotorMaxNow);
            buffer.AppendData(mcconf.LoCurrentMotorMinNow);
            buffer.AppendData(mcconf.SlMinErpm);
            buffer.AppendData(mcconf.SlMinErpmCycleIntLimit);
            buffer.AppendData(mcconf.SlMaxFullbreakCurrentDirChange);
            buffer.AppendData(mcconf.SlCycleIntLimit);
            buffer.AppendData(mcconf.SlPhaseAdvanceAtBr);
            buffer.AppendData(mcconf.SlCycleIntRpmBr);
            buffer.AppendData(mcconf.SlBemfCouplingK);
            buffer.AppendData(mcconf.HallTable);
            buffer.AppendData(mcconf.HallSlErpm);
            buffer.AppendData(mcconf.FocCurrentKp);
            buffer.AppendData(mcconf.FocCurrentKi);
            buffer.AppendData(mcconf.FocFSw);
            buffer.AppendData(mcconf.FocDtUs);
            buffer.AppendData(mcconf.FocEncoderOffset);
            buffer.AppendData(mcconf.FocEncoderInverted);
            buffer.AppendData(mcconf.FocEncoderRatio);
            buffer.AppendData(mcconf.FocMotorL);
            buffer.AppendData(mcconf.FocMotorR);
            buffer.AppendData(mcconf.FocMotorFluxLinkage);
            buffer.AppendData(mcconf.FocObserverGain);
            buffer.AppendData(mcconf.FocObserverGainSlow);
            buffer.AppendData(mcconf.FocPllKp);
            buffer.AppendData(mcconf.FocPllKi);
            buffer.AppendData(mcconf.FocDutyDowmrampKp);
            buffer.AppendData(mcconf.FocDutyDowmrampKi);
            buffer.AppendData(mcconf.FocOpenloopRpm);
            buffer.AppendData(mcconf.FocSlOpenloopHyst);
            buffer.AppendData(mcconf.FocSlOpenloopTime);
            buffer.AppendData(mcconf.FocSlDCurrentDuty);
            buffer.AppendData(mcconf.FocSlDCurrentFactor);
            buffer.AppendData(mcconf.FocSensorMode);
            buffer.AppendData(mcconf.FocHallTable);
            buffer.AppendData(mcconf.FocSlErpm);
            buffer.AppendData(mcconf.FocSampleV0V7);
            buffer.AppendData(mcconf.FocSampleHighCurrent);
            buffer.AppendData(mcconf.FocSatComp);
            buffer.AppendData(mcconf.FocTempComp);
            buffer.AppendData(mcconf.FocTempCompBaseTemp);
            buffer.AppendData(mcconf.FocCurrentFilterConst);
            buffer.AppendData(mcconf.SPidKp);
            buffer.AppendData(mcconf.SPidKi);
            buffer.AppendData(mcconf.SPidKd);
            buffer.AppendData(mcconf.SPidKdFilter);
            buffer.AppendData(mcconf.SPidMinErpm);
            buffer.AppendData(mcconf.SPidAllowBraking);
            buffer.AppendData(mcconf.PPidKp);
            buffer.AppendData(mcconf.PPidKi);
            buffer.AppendData(mcconf.PPidKd);
            buffer.AppendData(mcconf.PPidKdFilter);
            buffer.AppendData(mcconf.PPidAngDiv);
            buffer.AppendData(mcconf.CcStartupBoostDuty);
            buffer.AppendData(mcconf.CcMinCurrent);
            buffer.AppendData(mcconf.CcGain);
            buffer.AppendData(mcconf.CcRampStepMax);
            buffer.AppendData(mcconf.MFaultStopTimeMs);
            buffer.AppendData(mcconf.MDutyRampStep);
            buffer.AppendData(mcconf.MCurrentBackoffGain);
            buffer.AppendData(mcconf.MEncoderCounts);
            buffer.AppendData(mcconf.MSensorPortMode);
            buffer.AppendData(mcconf.MInvertDirection);
            buffer.AppendData(mcconf.MDrv8301OcMode);
            buffer.AppendData(mcconf.MDrv8301OcAdj);
            buffer.AppendData(mcconf.MBldcFSwMin);
            buffer.AppendData(mcconf.MBldcFSwMax);
            buffer.AppendData(mcconf.MDcFSw);
            buffer.AppendData(mcconf.MNtcMotorBeta);
            buffer.AppendData(mcconf.MOutAuxMode);
            comm.Send(buffer);
        }

        public void SetPos(float pos)
        {
            buffer.AppendData(CommPacketId.SetPos);
            buffer.AppendData(pos, 1000000.0F);
            comm.Send(buffer);
        }

        public void SetRpm(int rpm)
        {
            buffer.AppendData(CommPacketId.SetRpm);
            buffer.AppendData(rpm);
            comm.Send(buffer);
        }

        public void SetServoPos(float pos)
        {
            buffer.AppendData(CommPacketId.SetServoPos);
            buffer.AppendData(pos, 1000.0F);
            comm.Send(buffer);
        }

        public void TerminalCmd(string cmd)
        {
            buffer.AppendData(CommPacketId.TerminalCmd);
            buffer.AppendData(cmd);
            comm.Send(buffer);
        }
    }
}
