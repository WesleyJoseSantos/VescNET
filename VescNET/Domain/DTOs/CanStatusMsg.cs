using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.DTOs
{
    public class CanStatusMsg
    {
        public int Id { get; set; }
        public int RxTime { get; set; }
        public int Rpm { get; set; }
        public float Current { get; set; }
        public float Duty { get; set; }
    }
}
