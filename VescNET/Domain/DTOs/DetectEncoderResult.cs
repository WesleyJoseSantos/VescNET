using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.DTOs
{
    public class DetectEncoderResult
    {
        public float Offset { get; set; }
        public float Ratio { get; set; }
        public bool Inverted { get; set; }
    }
}
