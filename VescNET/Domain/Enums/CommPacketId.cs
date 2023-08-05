using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum CommPacketId
    {
        FwVersion = 0,
        JumpToBootloader,
        EraseNewApp,
        WriteNewAppData,
        GetValues,
        SetDuty,
        SetCurrent,
        SetCurrentBrake,
        SetRpm,
        SetPos,
        SetHandbrake,
        SetDetect,
        SetServoPos,
        SetMcConf,
        GetMcConf,
        GetMcConfDefault,
        SetAppConf,
        GetAppConf,
        GetAppConfDefault,
        SamplePrint,
        TerminalCmd,
        Print,
        RotorPosition,
        ExperimentSample,
        DetectMotorParam,
        DetectMotorRL,
        DetectMotorFluxLinkage,
        DetectEncoder,
        DetectHallFoc,
        Reboot,
        Alive,
        GetDecodedPpm,
        GetDecodedAdc,
        GetDecodedChuk,
        ForwardCan,
        SetChuckData,
        CustomAppData,
        NrfStartPairing
    }
}
