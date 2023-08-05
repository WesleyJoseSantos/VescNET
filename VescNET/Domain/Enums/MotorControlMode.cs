﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum MotorControlMode
    {
        Duty = 0,
        Current,
        CurrentBrake,
        Rpm,
        Pos
    }
}
