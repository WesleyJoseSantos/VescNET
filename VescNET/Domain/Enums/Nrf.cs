using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Enums
{
    public enum NrfSpeed
    {
        Speed250K = 0,
        Speed1M,
        Speed2M
    }

    public enum NrfPower
    {
        PowerM18dBm = 0,
        PowerM12dBm,
        PowerM6dBm,
        Power0dBm,
        PowerOff
    }

    public enum NrfAw
    {
        Aw3 = 0,
        Aw4,
        Aw5
    }

    public enum NrfCrc
    {
        CrcDisabled = 0,
        Crc1B,
        Crc2B
    }

    public enum NrfRetrDelay
    {
        Delay250us = 0,
        Delay500us,
        Delay750us,
        Delay1000us,
        Delay1250us,
        Delay1500us,
        Delay1750us,
        Delay2000us,
        Delay2250us,
        Delay2500us,
        Delay2750us,
        Delay3000us,
        Delay3250us,
        Delay3500us,
        Delay3750us,
        Delay4000us
    }
}
