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

        public CanConfig CanConfig { get; set; }

        public bool PairingDone { get; set; }
        public bool EnablePermanentUart { get; set; }
        public byte ShutdownMode { get; set; }
        public bool ServoOutEnabled { get; set; }
        public byte KillSwitchMode { get; set; }

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

        // Balance application settings
        public BalanceConfig BalanceConf { get; set; }

        // PAS application settings
        public PasConfig PasConf { get; set; }

        // IMU application settings
        public ImuConfig ImuConf { get; set; }

        public AppConfiguration()
        {
            CanConfig = new CanConfig();
            PpmConf = new PpmConfig();
            AdcConf = new AdcConfig();
            ChukConf = new ChukConfig();
            NrfConf = new NrfConfig();
            BalanceConf = new BalanceConfig();
            PasConf = new PasConfig();
            ImuConf = new ImuConfig();
        }
    }
}
