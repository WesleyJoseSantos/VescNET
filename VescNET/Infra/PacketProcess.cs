using System;
using System.IO;
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
                //case CommPacketId.EraseNewApp:
                //    OnEraseNewApp(buffer);
                //    break;
                //case CommPacketId.WriteNewAppData:
                //    OnWriteNewAppData(buffer);
                //    break;
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
                //case CommPacketId.SetMcConf:
                //    // This is a confirmation that the new mcconf is received.
                //    break;
                case CommPacketId.GetMcConf:
                case CommPacketId.GetMcConfDefault:
                    OnGetMcConf(buffer);
                    break;
                //case CommPacketId.SetAppConf:
                //    // This is a confirmation that the new appconf is received.
                //    break;
                case CommPacketId.GetAppConf:
                case CommPacketId.GetAppConfDefault:
                    OnGetAppConf(buffer);
                    break;
                //case CommPacketId.SamplePrint:
                //    OnSamplePrint(buffer);
                //    break;
                // case CommPacketId.TerminalCmd:
                //     OnTerminalCmd(buffer);
                //     break;
                //case CommPacketId.Print:
                //    OnPrint(buffer);
                //    break;
                //case CommPacketId.RotorPosition:
                //    OnRotorPosition(buffer);
                //    break;
                //case CommPacketId.ExperimentSample:
                //    OnExperimentSample(buffer);
                //    break;
                //case CommPacketId.DetectMotorParam:
                //    OnDetectMotorParam(buffer);
                //    break;
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
                //case CommPacketId.GetDecodedPpm:
                //    OnGetDecodedPPM(buffer);
                //    break;
                //case CommPacketId.GetDecodedAdc:
                //    OnGetDecodedADC(buffer);
                //    break;
                //case CommPacketId.GetDecodedChuk:
                //    OnGetDecodedChuk(buffer);
                //    break;
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
                default:
                    throw new InvalidDataException("DataType: " + _recv.PacketId);
            }

            return _recv;
        }

        static public void PrintData(ReceivedData data)
        {
            switch (data.PacketId)
            {
                case CommPacketId.FwVersion:
                    {
                        var e = data.Data as DeviceInfo;
                        Console.WriteLine($"Firmware Version: {e.FirmwareVersion}");
                        Console.WriteLine($"Hardware Version: {e.HardwareVersion}");
                        Console.WriteLine($"UUID: {BitConverter.ToString(e.Uuid)}");
                    }
                    break;
                case CommPacketId.JumpToBootloader:
                    break;
                case CommPacketId.EraseNewApp:
                    break;
                case CommPacketId.WriteNewAppData:
                    break;
                case CommPacketId.GetValues:
                    {
                        var e = data.Data as McValues;
                        Console.WriteLine($"VIn: {e.VIn}");
                        Console.WriteLine($"TempMos: {e.TempMos}");
                        Console.WriteLine($"TempMotor: {e.TempMotor}");
                        Console.WriteLine($"CurrentMotor: {e.CurrentMotor}");
                        Console.WriteLine($"CurrentIn: {e.CurrentIn}");
                        Console.WriteLine($"Id: {e.Id}");
                        Console.WriteLine($"Iq: {e.Iq}");
                        Console.WriteLine($"Rpm: {e.Rpm}");
                        Console.WriteLine($"DutyNow: {e.DutyNow}");
                        Console.WriteLine($"AmpHours: {e.AmpHours}");
                        Console.WriteLine($"AmpHoursCharged: {e.AmpHoursCharged}");
                        Console.WriteLine($"WattHours: {e.WattHours}");
                        Console.WriteLine($"WattHoursCharged: {e.WattHoursCharged}");
                        Console.WriteLine($"Tachometer: {e.Tachometer}");
                        Console.WriteLine($"TachometerAbs: {e.TachometerAbs}");
                        Console.WriteLine($"FaultCode: {e.FaultCode}");
                        Console.WriteLine($"PidPos: {e.PidPos}");
                        Console.WriteLine($"VescId: {e.VescId}");
                    }
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

        private void OnFwVersion(IBuffer buffer) 
        {
            var data = new DeviceInfo();
            int ind = 1;

            byte[] firmware = buffer.GetData<byte>(ref ind, 2);
            byte[] hardware = buffer.GetData<byte>(ref ind, 3);

            data.FirmwareVersion = $"{firmware[0]}.{firmware[1]}";
            data.HardwareVersion = Encoding.ASCII.GetString(hardware).Trim();
            data.Uuid = buffer.GetData<byte>(ref ind, 12);

            _recv.Data = data;
        }

        private void OnGetValues(IBuffer buffer)
        {
            McValues data = new McValues();
            int ind = 1;

            data.TempMos = buffer.GetHalf<float>(ref ind, 1e1f);
            data.TempMotor = buffer.GetHalf<float>(ref ind, 1e1f);
            data.CurrentMotor = buffer.GetData<float>(ref ind, 1e2f);
            data.CurrentIn = buffer.GetData<float>(ref ind, 1e2f);
            data.Id = buffer.GetData<float>(ref ind, 1e2f);
            data.Iq = buffer.GetData<float>(ref ind, 1e2f);
            data.DutyNow = buffer.GetHalf<float>(ref ind, 1e3f);
            data.Rpm = buffer.GetData<float>(ref ind, 1e0f);
            data.VIn = buffer.GetHalf<float>(ref ind, 1e1f);
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

        private void OnGetMcConf(IBuffer buffer)
        {
            int ind = 1;
            var data = new McConfiguration();

            var mcConfSignature = buffer.GetData<uint>(ref ind);

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
            data.LErpmStart = buffer.GetHalf<float>(ref ind, 10000f);
            data.LMaxErpmFbrake = buffer.GetData<float>(ref ind);
            data.LMaxErpmFbrakeCc = buffer.GetData<float>(ref ind);
            data.LMinVin = buffer.GetData<float>(ref ind);
            data.LMaxVin = buffer.GetData<float>(ref ind);
            data.LBatteryCutStart = buffer.GetData<float>(ref ind);
            data.LBatteryCutEnd = buffer.GetData<float>(ref ind);
            data.LSlowAbsCurrent = buffer.GetData<bool>(ref ind);
            data.LTempFetStart = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LTempFetEnd = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LTempMotorStart = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LTempMotorEnd = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LTempAccelDec = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LMinDuty = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LMaxDuty = buffer.GetHalf<float>(ref ind, 1.0f);
            data.LWattMax = buffer.GetData<float>(ref ind);
            data.LWattMin = buffer.GetData<float>(ref ind);

            data.LCurrentMaxScale = buffer.GetHalf<float>(ref ind, 10000f);
            data.LCurrentMinScale = buffer.GetHalf<float>(ref ind, 10000f);
            data.LDutyStart = buffer.GetHalf<float>(ref ind, 10000f);

            data.SlMinErpm = buffer.GetData<float>(ref ind);
            data.SlMinErpmCycleIntLimit = buffer.GetData<float>(ref ind);
            data.SlMaxFullbreakCurrentDirChange = buffer.GetData<float>(ref ind);
            data.SlCycleIntLimit = buffer.GetHalf<float>(ref ind, 10f);
            data.SlPhaseAdvanceAtBr = buffer.GetHalf<float>(ref ind, 10000f);
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

            data.FocEncoderSinGain = buffer.GetData<float>(ref ind);
            data.FocEncoderCosGain = buffer.GetData<float>(ref ind);
            data.FocEncoderSinOffset = buffer.GetData<float>(ref ind);
            data.FocEncoderCosOfset = buffer.GetData<float>(ref ind);
            data.FocEncoderSinCosFilterConstant = buffer.GetData<float>(ref ind);

            data.FocSensorMode = (McFocSensorMode)buffer.GetData<byte>(ref ind);
            data.FocSpeedTrackerKp = buffer.GetData<float>(ref ind);
            data.FocSpeedTrackerKi = buffer.GetData<float>(ref ind);
            data.FocMotorL = buffer.GetData<float>(ref ind);
            data.FocMotorLdLqDiff = buffer.GetData<float>(ref ind);
            data.FocMotorR = buffer.GetData<float>(ref ind);
            data.FocMotorFluxLinkage = buffer.GetData<float>(ref ind);
            data.FocObserverGain = buffer.GetData<float>(ref ind);
            data.FocObserverGainSlow = buffer.GetData<float>(ref ind);
            data.FocObserverOffset = buffer.GetHalf<float>(ref ind, 1f);
            data.FocDutyDowmrampKp = buffer.GetData<float>(ref ind);
            data.FocDutyDowmrampKi = buffer.GetData<float>(ref ind);
            data.FocOpenloopRpm = buffer.GetData<float>(ref ind);
            data.FocOpenloopRpmLow = buffer.GetHalf<float>(ref ind, 1000f);
            data.FocDGainScaleStart = buffer.GetData<float>(ref ind);
            data.FocDGainScaleMaxMod = buffer.GetData<float>(ref ind);
            data.FocSlOpenloopHyst = buffer.GetHalf<float>(ref ind, 100f);
            data.FocSlOpenloopTimeLock = buffer.GetHalf<float>(ref ind, 100f);
            data.FocSlOpenloopTimeRamp = buffer.GetHalf<float>(ref ind, 100f);
            data.FocSlOpenloopTime = buffer.GetHalf<float>(ref ind, 100f);

            data.FocHallTable = buffer.GetData<byte>(ref ind, 8);
            data.FocHallInterpErpm = buffer.GetData<float>(ref ind);

            data.FocSlErpm = buffer.GetData<float>(ref ind);
            data.FocSampleV0V7 = buffer.GetData<bool>(ref ind);
            data.FocSampleHighCurrent = buffer.GetData<bool>(ref ind);
            data.FocSatComp = buffer.GetHalf<float>(ref ind, 1000f);
            data.FocTempComp = buffer.GetData<bool>(ref ind);
            data.FocTempCompBaseTemp = buffer.GetHalf<float>(ref ind, 100f);
            data.FocCurrentFilterConst = buffer.GetHalf<float>(ref ind, 10000f);

            data.FocCcDecoupling = buffer.GetData<byte>(ref ind);
            data.FocObserverType = buffer.GetData<byte>(ref ind);
            data.FocHfiVoltageStart = buffer.GetData<float>(ref ind);
            data.FocHfiVoltageRun = buffer.GetData<float>(ref ind);
            data.FocHfiVoltageMax = buffer.GetData<float>(ref ind);
            //data.FocHfiGain = buffer.GetHalf<float>(ref ind, 1000f);
            //data.FocHfiHyst = buffer.GetHalf<float>(ref ind, 100f);
            data.FocSlErpmHfi = buffer.GetData<float>(ref ind);
            data.FocHfiStartSamples = buffer.GetData<ushort>(ref ind);
            data.FocHfiObsOvrSec = buffer.GetData<float>(ref ind);
            data.FocHfiSamples = buffer.GetData<byte>(ref ind);
            data.FocOffsetsCalOnBoot = buffer.GetData<byte>(ref ind);

            data.FocOffsetsCurrent = buffer.GetData<float>(ref ind, 3);
            data.FocOffsetsVoltage = buffer.GetHalf<float>(ref ind, 3, 10000f);
            data.FocOffsetsVoltageUndriven = buffer.GetHalf<float>(ref ind, 3, 10000f);
            
            data.FocPhaseFilterEnable = buffer.GetData<bool>(ref ind);
            //data.FocPhaseFilterDisableFault = buffer.GetData<bool>(ref ind);
            data.FocPhaseFilterMaxErpm = buffer.GetData<float>(ref ind);
            data.FocMtpaMode = buffer.GetData<byte>(ref ind);
            data.FocFwCurrentMax = buffer.GetData<float>(ref ind);
            data.FocFwDutyStart = buffer.GetHalf<float>(ref ind, 10000f);
            data.FocFwRampTime = buffer.GetHalf<float>(ref ind, 1000f);
            data.FocFwQCurrentFactor = buffer.GetHalf<float>(ref ind, 10000f);
            //data.FocSpeedSoure = buffer.GetData<byte>(ref ind);

            data.GpdBufferNotifyLeft = buffer.GetData<ushort>(ref ind);
            data.GpdBufferInterpol = buffer.GetData<ushort>(ref ind);
            data.GpdCurrentFilterConst = buffer.GetHalf<float>(ref ind, 10000f);
            data.GpdCurrentKp = buffer.GetData<float>(ref ind);
            data.GpdCurrentKi = buffer.GetData<float>(ref ind);

            data.SPidLoopRate = buffer.GetData<byte>(ref ind);
            data.SPidKp = buffer.GetData<float>(ref ind);
            data.SPidKi = buffer.GetData<float>(ref ind);
            data.SPidKd = buffer.GetData<float>(ref ind);
            data.SPidKdFilter = buffer.GetHalf<float>(ref ind, 10000f);
            data.SPidMinErpm = buffer.GetData<float>(ref ind);
            data.SPidAllowBraking = buffer.GetData<bool>(ref ind);
            data.SPidRampErpmsS = buffer.GetData<float>(ref ind);

            data.PPidKp = buffer.GetData<float>(ref ind);
            data.PPidKi = buffer.GetData<float>(ref ind);
            data.PPidKd = buffer.GetData<float>(ref ind);
            data.PPidKdProc = buffer.GetData<float>(ref ind);
            data.PPidKdFilter = buffer.GetData<float>(ref ind);
            data.PPidAngDiv = buffer.GetData<float>(ref ind);
            data.PPidGainDecAngle = buffer.GetHalf<float>(ref ind, 10f);
            data.PPidOffset = buffer.GetData<float>(ref ind);

            data.CcStartupBoostDuty = buffer.GetData<float>(ref ind);
            data.CcMinCurrent = buffer.GetData<float>(ref ind);
            data.CcControllerGain = buffer.GetData<float>(ref ind);
            data.CcRampStepMax = buffer.GetData<float>(ref ind);

            data.MFaultStopTimeMs = buffer.GetData<int>(ref ind);
            data.MDutyRampStep = buffer.GetData<float>(ref ind);
            data.MCurrentBackoffGain = buffer.GetData<float>(ref ind);
            data.MEncoderCounts = buffer.GetData<uint>(ref ind);
            //data.MEncoderSinAmp = buffer.GetHalf<float>(ref ind, 1000f);
            //data.MEncoderCosAmp = buffer.GetHalf<float>(ref ind, 1000f);
            //data.MEncoderSinOffset = buffer.GetHalf<float>(ref ind, 1000f);
            //data.MEncoderCosOffset = buffer.GetHalf<float>(ref ind, 1000f);
            //data.MEncoderSincosFilterConstant = buffer.GetHalf<float>(ref ind, 1000f);
            //data.MEncoderSincosPhaseCorrection = buffer.GetHalf<float>(ref ind, 1000f);
            data.MSensorPortMode = (SensorPortMode)buffer.GetData<byte>(ref ind);
            data.MInvertDirection = buffer.GetData<bool>(ref ind);
            data.MDrv8301OcMode = (Drv8301OcMode)buffer.GetData<byte>(ref ind);
            data.MDrv8301OcAdj = buffer.GetData<byte>(ref ind);
            data.MBldcFSwMin = buffer.GetData<float>(ref ind);
            data.MBldcFSwMax = buffer.GetData<float>(ref ind);
            data.MDcFSw = buffer.GetData<float>(ref ind);
            data.MNtcMotorBeta = buffer.GetData<float>(ref ind);
            data.MOutAuxMode = (OutAuxMode)buffer.GetData<byte>(ref ind);
            data.MMotorTempSensType = (TempSensorType)buffer.GetData<byte>(ref ind);
            data.MPtcMotorCoeff = buffer.GetData<float>(ref ind);
            data.MNtcxPtcxRes = buffer.GetHalf<float>(ref ind, 0f);
            data.MNtcxPtcxTempBase = buffer.GetHalf<float>(ref ind, 10f);
            data.MHallExtraSamples = buffer.GetData<byte>(ref ind);
            //data.MBattFilterConst = buffer.GetData<byte>(ref ind);

            data.SiMotorPoles = buffer.GetData<byte>(ref ind);
            data.SiGearRatio = buffer.GetData<float>(ref ind);
            data.SiWheelDiameter = buffer.GetData<float>(ref ind);
            data.SiBatteryType = (BatteryType)buffer.GetData<byte>(ref ind);
            data.SiBatteryCells = buffer.GetData<byte>(ref ind);
            data.SiBatteryAh = buffer.GetData<float>(ref ind);
            data.SiMotorNlCurrent = buffer.GetData<float>(ref ind);

            data.Bms.Type = (BmsType)buffer.GetData<byte>(ref ind);
            //data.Bms.LimitMode = buffer.GetData<byte>(ref ind);
            data.Bms.TLimitStart = buffer.GetHalf<float>(ref ind, 100f);
            data.Bms.TLimitEnd = buffer.GetHalf<float>(ref ind, 100f);
            data.Bms.SocLimitStart = buffer.GetHalf<float>(ref ind, 1000f);
            data.Bms.SocLimitEnd = buffer.GetHalf<float>(ref ind, 1000f);
            data.Bms.FwdCanMode = (BmsFwdCanMode)buffer.GetData<byte>(ref ind);

            _recv.Data = data;
        }

        void OnGetAppConf(IBuffer buffer)
        {
            int ind = 1;
            var data = new AppConfiguration();

            var appSignature = buffer.GetData<uint>(ref ind);

            data.ControllerId = buffer.GetData<byte>(ref ind);
            data.TimeoutMsec = buffer.GetData<uint>(ref ind);
            data.TimeoutBrakeCurrent = buffer.GetData<float>(ref ind);

            data.CanConfig.StatusMessageMode = buffer.GetData<ushort>(ref ind);
            data.CanConfig.StatusRateHz = buffer.GetData<byte>(ref ind);
            data.CanConfig.BaudRate = (CanBaud)buffer.GetData<byte>(ref ind);

            data.PairingDone = buffer.GetData<bool>(ref ind);
            data.EnablePermanentUart = buffer.GetData<bool>(ref ind);
            data.ShutdownMode = buffer.GetData<byte>(ref ind);

            data.CanConfig.CanMode = buffer.GetData<byte>(ref ind);
            data.CanConfig.Uav.EscIndex = buffer.GetData<byte>(ref ind);
            data.CanConfig.Uav.RawThrottleMode = buffer.GetData<byte>(ref ind);
            data.CanConfig.Uav.RawRpmMax = buffer.GetData<float>(ref ind);

            data.ServoOutEnabled = buffer.GetData<bool>(ref ind);
            data.KillSwitchMode = buffer.GetData<byte>(ref ind);

            data.AppToUse = (AppUse)buffer.GetData<byte>(ref ind);

            data.PpmConf.CtrlType = (PpmControlType)buffer.GetData<byte>(ref ind);
            data.PpmConf.PidMaxErpm = buffer.GetData<float>(ref ind);
            data.PpmConf.Hyst = buffer.GetData<float>(ref ind);
            data.PpmConf.PulseStart = buffer.GetData<float>(ref ind);
            data.PpmConf.PulseEnd = buffer.GetData<float>(ref ind);
            data.PpmConf.PulseCenter = buffer.GetData<float>(ref ind);
            data.PpmConf.MedianFilter = buffer.GetData<bool>(ref ind);
            data.PpmConf.SafeStart = buffer.GetData<byte>(ref ind);
            data.PpmConf.ThrottleExp = buffer.GetData<float>(ref ind);
            data.PpmConf.ThrottleExpBrake = buffer.GetData<float>(ref ind);
            data.PpmConf.ThrottleExpMode = (ThrExpMode)buffer.GetData<byte>(ref ind);
            data.PpmConf.RampTimePos = buffer.GetData<float>(ref ind);
            data.PpmConf.RampTimeNeg = buffer.GetData<float>(ref ind);
            data.PpmConf.MultiEsc = buffer.GetData<bool>(ref ind);
            data.PpmConf.Tc = buffer.GetData<bool>(ref ind);
            data.PpmConf.TcMaxDiff = buffer.GetData<float>(ref ind);
            data.PpmConf.MaxErpmForDir = buffer.GetHalf<float>(ref ind, 1f);
            data.PpmConf.SmartRevMaxDuty = buffer.GetData<float>(ref ind);
            data.PpmConf.SmartRevRamptime = buffer.GetData<float>(ref ind);

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
            data.ChukConf.UseSmartRev = buffer.GetData<bool>(ref ind);
            data.ChukConf.SmartRevMaxDuty = buffer.GetData<float>(ref ind);
            data.ChukConf.SmartRevRamptime = buffer.GetData<float>(ref ind);

            data.NrfConf.Speed = (NrfSpeed)buffer.GetData<byte>(ref ind);
            data.NrfConf.Power = (NrfPower)buffer.GetData<byte>(ref ind);
            data.NrfConf.CrcType = (NrfCrc)buffer.GetData<byte>(ref ind);
            data.NrfConf.RetryDelay = (NrfRetrDelay)buffer.GetData<byte>(ref ind);
            data.NrfConf.Retries = buffer.GetData<byte>(ref ind);
            data.NrfConf.Channel = buffer.GetData<byte>(ref ind);
            data.NrfConf.Address = buffer.GetData<byte>(ref ind, 3);
            // data.NrfConf.SendCrcAck = buffer.GetData<bool>(ref ind);

            data.BalanceConf.PidMode = (BalancePidMode)buffer.GetData<byte>(ref ind);
            data.BalanceConf.Kp = buffer.GetData<float>(ref ind);
            data.BalanceConf.Ki = buffer.GetData<float>(ref ind);
            data.BalanceConf.Kd = buffer.GetData<float>(ref ind);
            //data.BalanceConf.Kp2 = buffer.GetData<float>(ref ind);
            //data.BalanceConf.Ki2 = buffer.GetData<float>(ref ind);
            //data.BalanceConf.Kd2 = buffer.GetData<float>(ref ind);
            data.BalanceConf.Hertz = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.LoopTimeFilter = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.FaultPitch = buffer.GetData<float>(ref ind);
            data.BalanceConf.FaultRoll = buffer.GetData<float>(ref ind);
            data.BalanceConf.FaultDuty = buffer.GetData<float>(ref ind);
            data.BalanceConf.FaultAdc1 = buffer.GetData<float>(ref ind);
            data.BalanceConf.FaultAdc2 = buffer.GetData<float>(ref ind);
            data.BalanceConf.FaultDelayPitch = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.FaultDelayRoll = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.FaultDelayDuty = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.FaultDelaySwitchHalf = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.FaultDelaySwitchFull = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.FaultAdcHalfErpm = buffer.GetData<ushort>(ref ind);
            //data.BalanceConf.FaultIsDualSwitch = buffer.GetData<bool>(ref ind);
            data.BalanceConf.TiltbackDutyAngle = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackDutySpeed = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackDuty = buffer.GetHalf<float>(ref ind, 1000f);
            data.BalanceConf.TiltbackHvAngle = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackHvSpeed = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackHv = buffer.GetData<float>(ref ind);
            data.BalanceConf.TiltbackLvAngle = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackLvSpeed = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackLv = buffer.GetData<float>(ref ind);
            data.BalanceConf.TiltbackReturnSpeed = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.TiltbackConstant = buffer.GetData<float>(ref ind);
            data.BalanceConf.TiltbackConstantErpm = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.TiltbackVariable = buffer.GetData<float>(ref ind);
            data.BalanceConf.TiltbackVariableMax = buffer.GetData<float>(ref ind);
            data.BalanceConf.NoseanglingSpeed = buffer.GetHalf<float>(ref ind, 100f);
            data.BalanceConf.StartupPitchTolerance = buffer.GetData<float>(ref ind);
            data.BalanceConf.StartupRollTolerance = buffer.GetData<float>(ref ind);
            data.BalanceConf.StartupSpeed = buffer.GetData<float>(ref ind);
            data.BalanceConf.Deadzone = buffer.GetData<float>(ref ind);
            data.BalanceConf.MultiEsc = buffer.GetData<bool>(ref ind);
            data.BalanceConf.YawKp = buffer.GetData<float>(ref ind);
            data.BalanceConf.YawKi = buffer.GetData<float>(ref ind);
            data.BalanceConf.YawKd = buffer.GetData<float>(ref ind);
            data.BalanceConf.RollSteerKp = buffer.GetData<float>(ref ind);
            data.BalanceConf.RollSteerErpmKp = buffer.GetData<float>(ref ind);
            data.BalanceConf.BrakeCurrent = buffer.GetData<float>(ref ind);
            data.BalanceConf.BrakeTimeout = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.YawCurrentClamp = buffer.GetData<float>(ref ind);
            //data.BalanceConf.KiLimit = buffer.GetData<float>(ref ind);
            data.BalanceConf.KdPt1LowpassFrequency = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.KdPt1HighpassFrequency = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.KdBiquadLowpass = buffer.GetData<float>(ref ind);
            data.BalanceConf.KdBiquadHighpass = buffer.GetData<float>(ref ind);
            data.BalanceConf.BoosterAngle = buffer.GetData<float>(ref ind);
            data.BalanceConf.BoosterRamp = buffer.GetData<float>(ref ind);
            data.BalanceConf.BoosterCurrent = buffer.GetData<float>(ref ind);
            data.BalanceConf.TorqueTiltStartCurrent = buffer.GetData<float>(ref ind);
            data.BalanceConf.TorqueTiltAngleLimit = buffer.GetData<float>(ref ind);
            data.BalanceConf.TorqueTiltOnSpeed = buffer.GetData<float>(ref ind);
            data.BalanceConf.TorqueTiltOffSpeed = buffer.GetData<float>(ref ind);
            data.BalanceConf.TorqueTiltStrength = buffer.GetData<float>(ref ind);
            data.BalanceConf.TorqueTiltFilter = buffer.GetData<float>(ref ind);
            data.BalanceConf.TurnTiltStrength = buffer.GetData<float>(ref ind);
            data.BalanceConf.TurnTiltAngleLimit = buffer.GetData<float>(ref ind);
            data.BalanceConf.TurnTiltStartAngle = buffer.GetData<float>(ref ind);
            data.BalanceConf.TurnTiltStartErpm = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.TurnTiltSpeed = buffer.GetData<float>(ref ind);
            data.BalanceConf.TurnTiltErpmBoost = buffer.GetData<ushort>(ref ind);
            data.BalanceConf.TurnTiltErpmBoostEnd = buffer.GetData<ushort>(ref ind);

            data.PasConf.CtrlType = (PasControlType)buffer.GetData<byte>(ref ind);
	        data.PasConf.SensorType = (PasSensorType)buffer.GetData<byte>(ref ind);
	        data.PasConf.CurrentScaling = buffer.GetHalf<float>(ref ind, 1000f);
	        data.PasConf.PedalRpmStart = buffer.GetHalf<float>(ref ind, 10f);
	        data.PasConf.PedalRpmEnd = buffer.GetHalf<float>(ref ind, 10f);
	        data.PasConf.InvertPedalDirection = buffer.GetData<bool>(ref ind);
	        data.PasConf.Magnets = buffer.GetData<ushort>(ref ind);
	        data.PasConf.UseFilter = buffer.GetData<bool>(ref ind);
	        data.PasConf.RampTimePos = buffer.GetHalf<float>(ref ind, 100f);
	        data.PasConf.RampTimeNeg = buffer.GetHalf<float>(ref ind, 100f);
	        data.PasConf.UpdateRateHz = buffer.GetData<ushort>(ref ind);

            data.ImuConf.Type = (ImuType)buffer.GetData<byte>(ref ind);
            data.ImuConf.Mode = (AhrsMode)buffer.GetData<byte>(ref ind);
            //data.ImuConf.Filter = (ImuFilter)buffer.GetData<byte>(ref ind);
            //data.ImuConf.AccelLowpassFilterX = buffer.GetHalf<float>(ref ind, 1);
            //data.ImuConf.AccelLowpassFilterY = buffer.GetHalf<float>(ref ind, 1);
            //data.ImuConf.AccelLowpassFilterZ = buffer.GetHalf<float>(ref ind, 1);
            //data.ImuConf.GyroLowpassFilter = buffer.GetHalf<float>(ref ind, 1);
            data.ImuConf.SampleRateHz = (int)buffer.GetData<ushort>(ref ind);
            //data.ImuConf.UseMagnetometer = buffer.GetData<bool>(ref ind);
            data.ImuConf.AccelConfidenceDecay = buffer.GetData<float>(ref ind);
            data.ImuConf.MahonyKp = buffer.GetData<float>(ref ind);
            data.ImuConf.MahonyKi = buffer.GetData<float>(ref ind);
            data.ImuConf.MadgwickBeta = buffer.GetData<float>(ref ind);
            data.ImuConf.RotRoll = buffer.GetData<float>(ref ind);
            data.ImuConf.RotPitch = buffer.GetData<float>(ref ind);
            data.ImuConf.RotYaw = buffer.GetData<float>(ref ind);
            data.ImuConf.AccelOffsets = buffer.GetData<float>(ref ind, 3);
            data.ImuConf.GyroOffsets = buffer.GetData<float>(ref ind, 3);

            Console.WriteLine("Test");
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
    }
}
