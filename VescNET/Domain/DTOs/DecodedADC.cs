using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.DTOs
{
    internal class DecodedADC
    {
        public float DecodedLevel { get; set; }
        public float Voltage { get; set; }
        public float DecodedLevel2 { get; set; }
        public float Voltage2 { get; set; }
    }
}
