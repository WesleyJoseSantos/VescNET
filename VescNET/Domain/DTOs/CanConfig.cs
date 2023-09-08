using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class CanConfig
    {
        public ushort StatusMessageMode { get; set; }
        public byte StatusRateHz { get; set; }
        public CanBaud BaudRate { get; set; }
        public byte CanMode { get; set; }
        public UavCanConfig Uav { get; set; }

        public CanConfig() 
        {
            Uav = new UavCanConfig();
        }
    }
}
