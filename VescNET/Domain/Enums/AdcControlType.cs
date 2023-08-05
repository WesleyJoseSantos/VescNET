using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum AdcControlType
    {
        None = 0,
        Current,
        CurrentRevCenter,
        CurrentRevButton,
        CurrentRevButtonBrakeAdc,
        CurrentNoReverseBrakeCenter,
        CurrentNoReverseBrakeButton,
        CurrentNoReverseBrakeAdc,
        Duty,
        DutyRevCenter,
        DutyRevButton,
        PID,
        PIDRevCenter,
        PIDRevButton
    }
}
