using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum PpmControlType
    {
        None = 0,
        Current,
        CurrentNoReverse,
        CurrentNoReverseBrake,
        Duty,
        DutyNoReverse,
        PID,
        PIDNoReverse
    }
}
