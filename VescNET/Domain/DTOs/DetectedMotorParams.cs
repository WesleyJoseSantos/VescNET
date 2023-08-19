using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.DTOs
{
    public class DetectedMotorParams
    {
        public float CycleIntLimit { get; set; }
        public float CouplingK { get; set; }
        public byte[] HalTable { get; set; }
        public byte HalRes { get; set; }
    }
}
