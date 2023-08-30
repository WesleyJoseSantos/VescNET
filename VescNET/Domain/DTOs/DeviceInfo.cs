using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.DTOs
{
    public class DeviceInfo
    {
        public string FirmwareVersion { get; set; }
        
        public string HardwareVersion { get; set; }

        public byte[] Uuid { get; set; }
    }
}
