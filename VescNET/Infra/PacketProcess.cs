using System;
using System.Text;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class PacketProcess : IPacketProcess
    {
        private ReceivedData _recv;
        private uint _payloadLenght;

        public PacketProcess()
        {
            _recv = new ReceivedData();
        }

        public ReceivedData Call(IBuffer buffer, uint payloadLenght)
        {
            if (buffer.Length == 0 || payloadLenght == 0) return null;

            _recv.PacketId = (CommPacketId)buffer.Data[0];
            _payloadLenght = payloadLenght;

            switch (_recv.PacketId)
            {
                case CommPacketId.FwVersion:
                    OnFwVersion(buffer);
                    break;
                case CommPacketId.EraseNewApp:
                    OnEraseNewApp(buffer);
                    break;
                case CommPacketId.WriteNewAppData:
                    OnWriteNewAppData(buffer);
                    break;
                case CommPacketId.GetValues:
                    OnGetValues(buffer);
                    break;
                // case CommPacketId.SetDuty:
                //     OnSetDuty(buffer);
                //     break;
                // case CommPacketId.SetCurrent:
                //     OnSetCurrent(buffer);
                //     break;
                // case CommPacketId.SetCurrentBrake:
                //     OnSetCurrentBrake(buffer);
                //     break;
                // case CommPacketId.SetRpm:
                //     OnSetRpm(buffer);
                //     break;
                // case CommPacketId.SetPos:
                //     OnSetPos(buffer);
                //     break;
                // case CommPacketId.SetHandbrake:
                //     OnSetHandbrake(buffer);
                //     break;
                // case CommPacketId.SetDetect:
                //     OnSetDetect(buffer);
                //     break;
                // case CommPacketId.SetServoPos:
                //     OnSetServoPos(buffer);
                //     break;
                case CommPacketId.SetMcConf:
                    // This is a confirmation that the new mcconf is received.
                    break;
                case CommPacketId.GetMcConf:
                    OnGetMcConf(buffer);
                    break;
                case CommPacketId.GetMcConfDefault:
                    OnGetMcConfDefault(buffer);
                    break;
                case CommPacketId.SetAppConf:
                    // This is a confirmation that the new appconf is received.
                    break;
                case CommPacketId.GetAppConf:
                    OnGetAppConf(buffer);
                    break;
                case CommPacketId.GetAppConfDefault:
                    OnGetAppConfDefault(buffer);
                    break;
                case CommPacketId.SamplePrint:
                    OnSamplePrint(buffer);
                    break;
                // case CommPacketId.TerminalCmd:
                //     OnTerminalCmd(buffer);
                //     break;
                case CommPacketId.Print:
                    OnPrint(buffer);
                    break;
                case CommPacketId.RotorPosition:
                    OnRotorPosition(buffer);
                    break;
                case CommPacketId.ExperimentSample:
                    OnExperimentSample(buffer);
                    break;
                case CommPacketId.DetectMotorParam:
                    OnDetectMotorParam(buffer);
                    break;
                // case CommPacketId.DetectMotorRL:
                //     OnDetectMotorRL(buffer);
                //     break;
                // case CommPacketId.DetectMotorFluxLinkage:
                //     OnDetectMotorFluxLinkage(buffer);
                //     break;
                // case CommPacketId.DetectEncoder:
                //     OnDetectEncoder(buffer);
                //     break;
                // case CommPacketId.DetectHallFoc:
                //     OnDetectHallFoc(buffer);
                //     break;
                // case CommPacketId.Reboot:
                //     OnReboot(buffer);
                //     break;
                // case CommPacketId.Alive:
                //     OnAlive(buffer);
                //     break;
                case CommPacketId.GetDecodedPpm:
                    OnGetDecodedPPM(buffer);
                    break;
                case CommPacketId.GetDecodedAdc:
                    OnGetDecodedADC(buffer);
                    break;
                case CommPacketId.GetDecodedChuk:
                    OnGetDecodedChuk(buffer);
                    break;
                    // case CommPacketId.ForwardCan:
                    //     OnForwardCan(buffer);
                    //     break;
                    // case CommPacketId.SetChuckData:
                    //     OnSetChuckData(buffer);
                    //     break;
                    // case CommPacketId.CustomAppData:
                    //     OnCustomAppData(buffer);
                    //     break;
                    // case CommPacketId.NrfStartPairing:
                    //     OnNrfStartPairing(buffer);
                    //     break;
            }

            return _recv;
        }

        private void OnFwVersion(IBuffer buffer) 
        {
            var data = new DeviceInfo();
            int ind = 0;

            byte[] firmware = buffer.GetData<byte>(ref ind, 2);
            byte[] hardware = buffer.GetData<byte>(ref ind, 3);

            data.FirmwareVersion = $"{firmware[0]}.{firmware[1]}";
            data.HardwareVersion = Encoding.ASCII.GetString(hardware).Trim();
            data.Uuid = buffer.GetData<byte>(ref ind, 12);

            _recv.Data = data;
        }

        private void OnEraseNewApp(IBuffer buffer)
        {
            // TODO
        }

        private void OnWriteNewAppData(IBuffer buffer)
        {
            // TODO
        }

        private void OnGetValues(IBuffer buffer)
        {
            McValues data = new McValues();
            int ind = 0;

            data.TempMos = buffer.GetData<float>(ref ind, 1e1f);
            data.TempMotor = buffer.GetData<float>(ref ind, 1e1f);
            data.CurrentMotor = buffer.GetData<float>(ref ind, 1e2f);
            data.CurrentIn = buffer.GetData<float>(ref ind, 1e2f);
            data.Id = buffer.GetData<float>(ref ind, 1e2f);
            data.Iq = buffer.GetData<float>(ref ind, 1e2f);
            data.DutyNow = buffer.GetData<float>(ref ind, 1e3f);
            data.Rpm = buffer.GetData<float>(ref ind, 1e0f);
            data.VIn = buffer.GetData<float>(ref ind, 1e1f);
            data.AmpHours = buffer.GetData<float>(ref ind, 1e4f);
            data.AmpHoursCharged = buffer.GetData<float>(ref ind, 1e4f);
            data.WattHours = buffer.GetData<float>(ref ind, 1e4f);
            data.WattHoursCharged = buffer.GetData<float>(ref ind, 1e4f);
            data.Tachometer = buffer.GetData<int>(ref ind);
            data.TachometerAbs = buffer.GetData<int>(ref ind);
            data.FaultCode = (McFaultCode)buffer.GetData<byte>(ref ind);

            if (ind < _payloadLenght) 
            {
			data.PidPos = buffer.GetData<float>(ref ind, 1e6f);
            } 
            else 
            {
                data.PidPos = 0.0f;
            }

            if (ind < _payloadLenght) 
            {
                data.VescId = buffer.GetData<byte>(ref ind);
            } 
            else 
            {
                data.VescId = 255;
            }

            _recv.Data = data;
        }

        private void OnSamplePrint(IBuffer buffer)
        {
            // TODO
        }

        private void OnPrint(IBuffer buffer)
        {
            foreach (byte b in buffer.Data)
            {
                Console.Write(b.ToString("X2") + " ");
            }
            Console.WriteLine();
        }

        private void OnRotorPosition(IBuffer buffer)
        {
            int ind = 0;
            var data = buffer.GetData<float>(ref ind, 100000.0f);
            _recv.Data = data;
        }

        private void OnExperimentSample(IBuffer buffer)
        {
            // TODO
        }

        private void OnGetMcConf(IBuffer buffer)
        {
            // TODO
        }

        private void OnGetMcConfDefault(IBuffer buffer)
        {
            int ind = 0;
            var data = new McConfiguration();

            data.PwmMode = (McPwmMode)buffer.GetData<byte>(ref ind);
            data.CommMode = (McCommMode)buffer.GetData<byte>(ref ind);
            data.MotorType = (McMotorType)buffer.GetData<byte>(ref ind);
            data.SensorMode = (McSensorMode)buffer.GetData<byte>(ref ind);

            data.LCurrentMax = buffer.GetData<float>(ref ind);
            data.LCurrentMin = buffer.GetData<float>(ref ind);
            data.LInCurrentMax = buffer.GetData<float>(ref ind);
            data.LInCurrentMin = buffer.GetData<float>(ref ind);
            data.LAbsCurrentMax = buffer.GetData<float>(ref ind);
            data.LMinErpm = buffer.GetData<float>(ref ind);
            data.LMaxErpm = buffer.GetData<float>(ref ind);
            data.LErpmStart = buffer.GetData<float>(ref ind);
            data.LMaxErpmFbrake = buffer.GetData<float>(ref ind);
            data.LMaxErpmFbrakeCc = buffer.GetData<float>(ref ind);
            data.LMinVin = buffer.GetData<float>(ref ind);
            data.LMaxVin = buffer.GetData<float>(ref ind);
            data.LBatteryCutStart = buffer.GetData<float>(ref ind);
            data.LBatteryCutEnd = buffer.GetData<float>(ref ind);
            data.LSlowAbsCurrent = buffer.GetData<bool>(ref ind);
            data.LTempFetStart = buffer.GetData<float>(ref ind);
            data.LTempFetEnd = buffer.GetData<float>(ref ind);
            data.LTempMotorStart = buffer.GetData<float>(ref ind);
            data.LTempMotorEnd = buffer.GetData<float>(ref ind);
            data.LTempAccelDec = buffer.GetData<float>(ref ind);
            data.LMinDuty = buffer.GetData<float>(ref ind);
            data.LMaxDuty = buffer.GetData<float>(ref ind);
            data.LWattMax = buffer.GetData<float>(ref ind);
            data.LWattMin = buffer.GetData<float>(ref ind);

            data.LoCurrentMax = data.LCurrentMax;
            data.LoCurrentMin = data.LCurrentMin;
            data.LoInCurrentMax = data.LInCurrentMax;
            data.LoInCurrentMin = data.LInCurrentMin;
            data.LoCurrentMotorMaxNow = data.LCurrentMax;
            data.LoCurrentMotorMinNow = data.LCurrentMin;

            data.SlMinErpm = buffer.GetData<float>(ref ind);
            data.SlMinErpmCycleIntLimit = buffer.GetData<float>(ref ind);
            data.SlMaxFullbreakCurrentDirChange = buffer.GetData<float>(ref ind);
            data.SlCycleIntLimit = buffer.GetData<float>(ref ind);
            data.SlPhaseAdvanceAtBr = buffer.GetData<float>(ref ind);
            data.SlCycleIntRpmBr = buffer.GetData<float>(ref ind);
            data.SlBemfCouplingK = buffer.GetData<float>(ref ind);

            data.HallTable = buffer.GetData<byte>(ref ind, 8);

            data.HallSlErpm = buffer.GetData<float>(ref ind);
            data.FocCurrentKp = buffer.GetData<float>(ref ind);
            data.FocCurrentKi = buffer.GetData<float>(ref ind);
            data.FocFSw = buffer.GetData<float>(ref ind);
            data.FocDtUs = buffer.GetData<float>(ref ind);
            data.FocEncoderInverted = buffer.GetData<bool>(ref ind);
            data.FocEncoderOffset = buffer.GetData<float>(ref ind);
            data.FocEncoderRatio = buffer.GetData<float>(ref ind);
            data.FocSensorMode = (McFocSensorMode)buffer.GetData<byte>(ref ind);
            data.FocPllKp = buffer.GetData<float>(ref ind);
            data.FocPllKi = buffer.GetData<float>(ref ind);
            data.FocMotorL = buffer.GetData<float>(ref ind);
            data.FocMotorR = buffer.GetData<float>(ref ind);
            data.FocMotorFluxLinkage = buffer.GetData<float>(ref ind);
            data.FocObserverGain = buffer.GetData<float>(ref ind);
            data.FocObserverGainSlow = buffer.GetData<float>(ref ind);
            data.FocDutyDowmrampKp = buffer.GetData<float>(ref ind);
            data.FocDutyDowmrampKi = buffer.GetData<float>(ref ind);
            data.FocOpenloopRpm = buffer.GetData<float>(ref ind);
            data.FocSlOpenloopHyst = buffer.GetData<float>(ref ind);
            data.FocSlOpenloopTime = buffer.GetData<float>(ref ind);
            data.FocSlDCurrentDuty = buffer.GetData<float>(ref ind);
            data.FocSlDCurrentFactor = buffer.GetData<float>(ref ind);

            data.FocHallTable = buffer.GetData<byte>(ref ind, 8);

            data.FocSlErpm = buffer.GetData<float>(ref ind);
            data.FocSampleV0V7 = buffer.GetData<bool>(ref ind);
            data.FocSampleHighCurrent = buffer.GetData<bool>(ref ind);
            data.FocSatComp = buffer.GetData<float>(ref ind);
            data.FocTempComp = buffer.GetData<bool>(ref ind);
            data.FocTempCompBaseTemp = buffer.GetData<float>(ref ind);
            data.FocCurrentFilterConst = buffer.GetData<float>(ref ind);

            data.SPidKp = buffer.GetData<float>(ref ind);
            data.SPidKi = buffer.GetData<float>(ref ind);
            data.SPidKd = buffer.GetData<float>(ref ind);
            data.SPidKdFilter = buffer.GetData<float>(ref ind);
            data.SPidMinErpm = buffer.GetData<float>(ref ind);
            data.SPidAllowBraking = buffer.GetData<bool>(ref ind);

            data.PPidKp = buffer.GetData<float>(ref ind);
            data.PPidKi = buffer.GetData<float>(ref ind);
            data.PPidKd = buffer.GetData<float>(ref ind);
            data.PPidKdFilter = buffer.GetData<float>(ref ind);
            data.PPidAngDiv = buffer.GetData<float>(ref ind);

            data.CcStartupBoostDuty = buffer.GetData<float>(ref ind);
            data.CcMinCurrent = buffer.GetData<float>(ref ind);
            data.CcGain = buffer.GetData<float>(ref ind);
            data.CcRampStepMax = buffer.GetData<float>(ref ind);

            data.MFaultStopTimeMs = buffer.GetData<int>(ref ind);
            data.MDutyRampStep = buffer.GetData<float>(ref ind);
            data.MCurrentBackoffGain = buffer.GetData<float>(ref ind);
            data.MEncoderCounts = buffer.GetData<uint>(ref ind);
            data.MSensorPortMode = (SensorPortMode)buffer.GetData<byte>(ref ind);
            data.MInvertDirection = buffer.GetData<bool>(ref ind);
            data.MDrv8301OcMode = (Drv8301OcMode)buffer.GetData<byte>(ref ind);
            data.MDrv8301OcAdj = buffer.GetData<byte>(ref ind);
            data.MBldcFSwMin = buffer.GetData<float>(ref ind);
            data.MBldcFSwMax = buffer.GetData<float>(ref ind);
            data.MDcFSw = buffer.GetData<float>(ref ind);
            data.MNtcMotorBeta = buffer.GetData<float>(ref ind);
            data.MOutAuxMode = (OutAuxMode)buffer.GetData<byte>(ref ind);

            _recv.Data = data;
        }

        static public void PrintData(ReceivedData data)
        {
            switch (data.PacketId)
            {
                case CommPacketId.FwVersion:
                    var e = data.Data as DeviceInfo;
                    Console.WriteLine($"Firmware Version: {e.FirmwareVersion}");
                    Console.WriteLine($"Hardware Version: {e.HardwareVersion}");
                    Console.WriteLine($"UUID: {BitConverter.ToString(e.Uuid)}");
                    break;
                case CommPacketId.JumpToBootloader:
                    break;
                case CommPacketId.EraseNewApp:
                    break;
                case CommPacketId.WriteNewAppData:
                    break;
                case CommPacketId.GetValues:
                    break;
                case CommPacketId.SetDuty:
                    break;
                case CommPacketId.SetCurrent:
                    break;
                case CommPacketId.SetCurrentBrake:
                    break;
                case CommPacketId.SetRpm:
                    break;
                case CommPacketId.SetPos:
                    break;
                case CommPacketId.SetHandbrake:
                    break;
                case CommPacketId.SetDetect:
                    break;
                case CommPacketId.SetServoPos:
                    break;
                case CommPacketId.SetMcConf:
                    break;
                case CommPacketId.GetMcConf:
                    break;
                case CommPacketId.GetMcConfDefault:
                    break;
                case CommPacketId.SetAppConf:
                    break;
                case CommPacketId.GetAppConf:
                    break;
                case CommPacketId.GetAppConfDefault:
                    break;
                case CommPacketId.SamplePrint:
                    break;
                case CommPacketId.TerminalCmd:
                    break;
                case CommPacketId.Print:
                    break;
                case CommPacketId.RotorPosition:
                    break;
                case CommPacketId.ExperimentSample:
                    break;
                case CommPacketId.DetectMotorParam:
                    break;
                case CommPacketId.DetectMotorRL:
                    break;
                case CommPacketId.DetectMotorFluxLinkage:
                    break;
                case CommPacketId.DetectEncoder:
                    break;
                case CommPacketId.DetectHallFoc:
                    break;
                case CommPacketId.Reboot:
                    break;
                case CommPacketId.Alive:
                    break;
                case CommPacketId.GetDecodedPpm:
                    break;
                case CommPacketId.GetDecodedAdc:
                    break;
                case CommPacketId.GetDecodedChuk:
                    break;
                case CommPacketId.ForwardCan:
                    break;
                case CommPacketId.SetChuckData:
                    break;
                case CommPacketId.CustomAppData:
                    break;
                case CommPacketId.NrfStartPairing:
                    break;
                default:
                    break;
            }
        }

        void OnGetAppConf(IBuffer buffer)
        {
            // TODO
        }

        void OnGetAppConfDefault(IBuffer buffer)
        {
            int ind = 0;
            var data = new AppConfiguration();

            data.ControllerId = buffer.GetData<byte>(ref ind);
            data.TimeoutMsec = buffer.GetData<uint>(ref ind);
            data.TimeoutBrakeCurrent = buffer.GetData<float>(ref ind);
            data.SendCanStatus = buffer.GetData<bool>(ref ind);
            data.SendCanStatusRateHz = buffer.GetData<ushort>(ref ind);
            data.CanBaudRate = (CanBaud)buffer.GetData<byte>(ref ind);

            data.AppToUse = (AppUse)buffer.GetData<byte>(ref ind);

            data.PpmConf.CtrlType = (PpmControlType)buffer.GetData<byte>(ref ind);
            data.PpmConf.PidMaxErpm = buffer.GetData<float>(ref ind);
            data.PpmConf.Hyst = buffer.GetData<float>(ref ind);
            data.PpmConf.PulseStart = buffer.GetData<float>(ref ind);
            data.PpmConf.PulseEnd = buffer.GetData<float>(ref ind);
            data.PpmConf.PulseCenter = buffer.GetData<float>(ref ind);
            data.PpmConf.MedianFilter = buffer.GetData<bool>(ref ind);
            data.PpmConf.SafeStart = buffer.GetData<bool>(ref ind);
            data.PpmConf.ThrottleExp = buffer.GetData<float>(ref ind);
            data.PpmConf.ThrottleExpBrake = buffer.GetData<float>(ref ind);
            data.PpmConf.ThrottleExpMode = (ThrExpMode)buffer.GetData<byte>(ref ind);
            data.PpmConf.RampTimePos = buffer.GetData<float>(ref ind);
            data.PpmConf.RampTimeNeg = buffer.GetData<float>(ref ind);
            data.PpmConf.MultiEsc = buffer.GetData<bool>(ref ind);
            data.PpmConf.Tc = buffer.GetData<bool>(ref ind);
            data.PpmConf.TcMaxDiff = buffer.GetData<float>(ref ind);

            data.AdcConf.CtrlType = (AdcControlType)buffer.GetData<byte>(ref ind);
            data.AdcConf.Hyst = buffer.GetData<float>(ref ind);
            data.AdcConf.VoltageStart = buffer.GetData<float>(ref ind);
            data.AdcConf.VoltageEnd = buffer.GetData<float>(ref ind);
            data.AdcConf.VoltageCenter = buffer.GetData<float>(ref ind);
            data.AdcConf.Voltage2Start = buffer.GetData<float>(ref ind);
            data.AdcConf.Voltage2End = buffer.GetData<float>(ref ind);
            data.AdcConf.UseFilter = buffer.GetData<bool>(ref ind);
            data.AdcConf.SafeStart = buffer.GetData<bool>(ref ind);
            data.AdcConf.CcButtonInverted = buffer.GetData<bool>(ref ind);
            data.AdcConf.RevButtonInverted = buffer.GetData<bool>(ref ind);
            data.AdcConf.VoltageInverted = buffer.GetData<bool>(ref ind);
            data.AdcConf.Voltage2Inverted = buffer.GetData<bool>(ref ind);
            data.AdcConf.ThrottleExp = buffer.GetData<float>(ref ind);
            data.AdcConf.ThrottleExpBrake = buffer.GetData<float>(ref ind);
            data.AdcConf.ThrottleExpMode = (ThrExpMode)buffer.GetData<byte>(ref ind);
            data.AdcConf.RampTimePos = buffer.GetData<float>(ref ind);
            data.AdcConf.RampTimeNeg = buffer.GetData<float>(ref ind);
            data.AdcConf.MultiEsc = buffer.GetData<bool>(ref ind);
            data.AdcConf.Tc = buffer.GetData<bool>(ref ind);
            data.AdcConf.TcMaxDiff = buffer.GetData<float>(ref ind);
            data.AdcConf.UpdateRateHz = buffer.GetData<ushort>(ref ind);

            data.UartBaudrate = buffer.GetData<uint>(ref ind);

            data.ChukConf.CtrlType = (Domain.DTOs.ChukControlType)buffer.GetData<byte>(ref ind);
            data.ChukConf.Hyst = buffer.GetData<float>(ref ind);
            data.ChukConf.RampTimePos = buffer.GetData<float>(ref ind);
            data.ChukConf.RampTimeNeg = buffer.GetData<float>(ref ind);
            data.ChukConf.StickErpmPerSInCc = buffer.GetData<float>(ref ind);
            data.ChukConf.ThrottleExp = buffer.GetData<float>(ref ind);
            data.ChukConf.ThrottleExpBrake = buffer.GetData<float>(ref ind);
            data.ChukConf.ThrottleExpMode = (ThrExpMode)buffer.GetData<byte>(ref ind);
            data.ChukConf.MultiEsc = buffer.GetData<bool>(ref ind);
            data.ChukConf.Tc = buffer.GetData<bool>(ref ind);
            data.ChukConf.TcMaxDiff = buffer.GetData<float>(ref ind);

            data.NrfConf.Speed = (NrfSpeed)buffer.GetData<byte>(ref ind);
            data.NrfConf.Power = (NrfPower)buffer.GetData<byte>(ref ind);
            data.NrfConf.CrcType = (NrfCrc)buffer.GetData<byte>(ref ind);
            data.NrfConf.RetryDelay = (NrfRetrDelay)buffer.GetData<byte>(ref ind);
            data.NrfConf.Retries = buffer.GetData<byte>(ref ind);
            data.NrfConf.Channel = buffer.GetData<byte>(ref ind);

            data.NrfConf.Address = buffer.GetData<byte>(ref ind, 3);

            data.NrfConf.SendCrcAck = buffer.GetData<bool>(ref ind);

            _recv.Data = data;
        }

        void OnDetectMotorParam(IBuffer buffer) 
        {
            var ind = 0;
            var data = new DetectedMotorParams();
            data.CycleIntLimit = buffer.GetData<float>(ref ind, 1000.0f);
            data.CouplingK = buffer.GetData<float>(ref ind, 1000.0f);
            data.HalTable = buffer.GetData<byte>(ref ind, 8);
            data.HalRes = buffer.GetData<byte>(ref ind);
            _recv.Data = data;
        }

        void OnGetDecodedPPM(IBuffer buffer) 
        {
            var ind = 0;
            var data = new DecodedPPM();
            data.Value = buffer.GetData<float>(ref ind, 1000000.0f);
            data.Lenght = buffer.GetData<float>(ref ind, 1000000.0f);
            _recv.Data = data;
        }

        void OnGetDecodedADC(IBuffer buffer)
        {
            var ind = 0;
            var data = new DecodedADC();
            data.Value = buffer.GetData<float>(ref ind, 1000000.0f);
            data.Voltage = buffer.GetData<float>(ref ind, 1000000.0f);
            _recv.Data = data;
        }

        void OnGetDecodedChuk(IBuffer buffer)
        {
            var ind = 0;
            _recv.Data = buffer.GetData<float>(ref ind, 1000000.0f);
        }
    }
}
