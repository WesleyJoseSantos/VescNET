using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class McValues
    {
        public float VIn { get; set; }
        public float TempMos { get; set; }
        public float TempMotor { get; set; }
        public float CurrentMotor { get; set; }
        public float CurrentIn { get; set; }
        public float Id { get; set; }
        public float Iq { get; set; }
        public float Rpm { get; set; }
        public float DutyNow { get; set; }
        public float AmpHours { get; set; }
        public float AmpHoursCharged { get; set; }
        public float WattHours { get; set; }
        public float WattHoursCharged { get; set; }
        public int Tachometer { get; set; }
        public int TachometerAbs { get; set; }
        public McFaultCode FaultCode { get; set; }
        public float PidPos { get; set; }
        public byte VescId { get; set; }
    }
}
