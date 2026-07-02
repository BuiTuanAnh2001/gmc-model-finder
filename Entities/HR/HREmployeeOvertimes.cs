using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HREmployeeOvertimes")]
    public class HREmployeeOvertimes : FixFiveProps
    {
        [Key]
        public int HREmployeeOvertimeID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public Nullable<DateTime> HREmployeeOvertimeFromDate { get; set; }
        public Nullable<DateTime> HREmployeeOvertimeToDate { get; set; }
        public string HREmployeeOvertimeApproveUser { get; set; } = string.Empty;
        public Boolean HREmployeeOvertimeIsApprove { get; set; } = true;
        public int FK_HROvertimeRateID { get; set; }
        public int FK_HRShiftID { get; set; }
        public string HREmployeeOvertimeTypeCombo { get; set; } = string.Empty;
        public string HREmployeeOvertimeApprovedPerson { get; set; } = string.Empty;
        public string HREmployeeOvertimeReasonDetail { get; set; } = string.Empty;
        public int HREmployeeOvertimePeriod { get; set; }
        public int HREmployeeOvertimeFiscalYear { get; set; }
        public Boolean AASelected { get; set; }
        public Boolean HREmployeeOvertimeOverDayCheck { get; set; }
        public string ApprovalStatusCombo { get; set; } = "New";
        public int FK_ADApprovalProcID { get; set; }
        public string HREmployeeOvertimeNo { get; set; } = string.Empty;
        public Boolean HREmployeeOvertimeCTCheck { get; set; }
        public decimal HREmployeeOvertimeBreakHour { get; set; }
        public decimal HREmployeeOvertimeHour { get; set; }
    }
}
