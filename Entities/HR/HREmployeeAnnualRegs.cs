using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HREmployeeAnnualRegs")]
    public class HREmployeeAnnualRegs : FixFiveProps
    {
        [Key]
        public int HREmployeeAnnualRegID { get; set; }
        public int FK_HRPeriodID { get; set; }
        public int HREmployeeAnnualRegMonth { get; set; }
        public int HREmployeeAnnualRegYear { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_HRDepartmentID { get; set; }
        public int FK_HRSectionID { get; set; }
        public int FK_HRAreaID { get; set; }
        public int FK_BRBranchID { get; set; }
        public int FK_HRPositionID { get; set; }
        public decimal HREmployeeAnnualRegDay { get; set; }
        public int FK_HRContractTypeID { get; set; }
        public decimal HREmployeeAnnualRegTotalDay { get; set; }
        public Nullable<DateTime> HREmployeeAnnualRegDate { get; set; }
    }
}
