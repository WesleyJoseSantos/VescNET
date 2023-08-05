using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum McPwmMode
    {
        NonSynchronousHisw = 0, // This mode is not recommended
        Synchronous, // The recommended and most tested mode
        Bipolar // Some glitches occasionally, can kill MOSFETs
    }

    public enum McCommMode
    {
        Integrate = 0,
        Delay
    }

    public enum McSensorMode
    {
        Sensorless = 0,
        Sensored,
        Hybrid
    }

    // Auxiliary output mode
    public enum OutAuxMode
    {
        Off = 0,
        OnAfter2s,
        OnAfter5s,
        OnAfter10s
    }

    public enum McFocSensorMode
    {
        Sensorless = 0,
        Encoder,
        Hall
    }

    public enum McMotorType
    {
        Bldc = 0,
        Dc,
        Foc
    }

    public enum McFaultCode
    {
        None = 0,
        OverVoltage,
        UnderVoltage,
        Drv,
        AbsOverCurrent,
        OverTempFet,
        OverTempMotor
    }
}
