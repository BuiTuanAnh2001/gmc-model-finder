using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HRAnnualLeaveOthers")]
    public class HRAnnualLeaveOthers : FixFiveProps
    {
        [Key]
        public int HRAnnualLeaveOtherID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_HRDepartmentID { get; set; }
        public int FK_HRPositionID { get; set; }
        public decimal HRAnnualLeaveOtherNumberYear { get; set; }
        public decimal HRAnnualLeaveOtherNumberVale { get; set; }
        public int FK_HREmployeeLeaveConfigID { get; set; }
    }
}
