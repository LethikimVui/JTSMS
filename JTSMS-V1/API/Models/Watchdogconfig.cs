using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace API.Models
{
    public partial class Watchdogconfig
    {
        public int WdconfigId { get; set; }
        public int? CustId { get; set; }
        public string ProcessStep { get; set; }
        public string RouteStep { get; set; }
        public string AssyNumber { get; set; }
        public string AssyRev { get; set; }
        public string TesterName { get; set; }
        public string TesterPcName { get; set; }
        public int? EquipmentId { get; set; }
        public int? TestTime { get; set; }
        public int? IsDmz { get; set; }
        public int? IsActive { get; set; }
    }
}
