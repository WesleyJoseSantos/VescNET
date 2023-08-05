using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class AppConfiguration
    {
        // Settings
        public byte ControllerId { get; set; }
        public uint TimeoutMsec { get; set; }
        public float TimeoutBrakeCurrent { get; set; }
        public bool SendCanStatus { get; set; }
        public uint SendCanStatusRateHz { get; set; }
        public CanBaud CanBaudRate { get; set; }

        // Application to use
        public AppUse AppToUse { get; set; }

        // PPM application settings
        public PpmConfig PpmConf { get; set; }

        // ADC application settings
        public AdcConfig AdcConf { get; set; }

        // UART application settings
        public uint UartBaudrate { get; set; }

        // Nunchuk application settings
        public ChukConfig ChukConf { get; set; }

        // NRF application settings
        public NrfConfig NrfConf { get; set; }
    }

}
