using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HREmployeeLSeniorityCfgs")]
    public class HREmployeeLSeniorityCfgs : FixFiveProps
    {
        [Key]
        public int HREmployeeLSeniorityCfgID { get; set; }
        public int HREmployeeLSeniorityCfgFromPeriod { get; set; }
        public int HREmployeeLSeniorityCfgToPeriod { get; set; }
        public int HREmployeeLSeniorityCfgNumberDays { get; set; }
        public int FK_HREmployeeLeaveConfigID { get; set; }
        public Boolean AASeleted { get; set; }

    }
}
