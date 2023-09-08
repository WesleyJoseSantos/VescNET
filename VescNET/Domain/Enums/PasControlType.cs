using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum PasControlType
    {
        None = 0,
        Cadence,
        Torque,
        TorqueWithCadenceTimeout
    }
}
