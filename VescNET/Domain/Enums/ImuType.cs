using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum ImuType
    {
        Off = 0,
        Internal,
        ExternalMpu9X50,
        ExternalIcm20948,
        ExternalBmi160,
        ExternalLsm6Ds3
    }
}
