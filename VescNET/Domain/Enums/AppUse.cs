using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum AppUse
    {
        None = 0,
        Ppm,
        Adc,
        Uart,
        PpmUart,
        AdcUart,
        Nunchuk,
        Nrf,
        Custom
    }
}
