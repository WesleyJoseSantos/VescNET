using System;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;

namespace VescNET.Domain.Interfaces
{
    public interface IBldc
    {
        void GetFwVersion();
        void GetValues();
        void GetMcconf();
        void GetAppconf();
        void GetDecodedPpm();
        void GetDecodedAdc();
        void GetDecodedChuk();

        void TerminalCmd(string cmd);
        void SetDutyCycle(float dutyCycle);
        void SetCurrent(float current);
        void SetCurrentBrake(float current);
        void SetRpm(int rpm);
        void SetPos(float pos);
        void SetHandbrake(float current);
        void SetServoPos(float pos);
        void SetMcconf(McConfiguration mcconf);
        void SetAppconf(AppConfiguration appconf);
    }
}
