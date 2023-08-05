using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class NrfConfig
    {
        public NrfSpeed Speed { get; set; }
        public NrfPower Power { get; set; }
        public NrfCrc CrcType { get; set; }
        public NrfRetrDelay RetryDelay { get; set; }
        public byte Retries { get; set; }
        public byte Channel { get; set; }
        public byte[] Address { get; set; }
        public bool SendCrcAck { get; set; }
    }
}
