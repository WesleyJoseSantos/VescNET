using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VescNET.Domain.Enums;

namespace VescNET.Domain.DTOs
{
    public class BmsConfig
    {
        public BmsType Type { get; set; }
        public byte LimitMode { get; set; }
        public float TLimitStart { get; set; }
        public float TLimitEnd { get; set; }
        public float SocLimitStart { get; set; }
        public float SocLimitEnd { get; set; }
        public BmsFwdCanMode FwdCanMode { get; set; }
    }
}
