using VescNET.Domain.DTOs;

namespace VescNET.Domain.Interfaces
{
    public interface IBldc
    {
        void GetFwVersion();
        void GetValues();
        void GetMcconf();
        void GetMcconfDefault();
        void GetAppconf();
        void GetAppconfDefault();

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
