using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{

    [Table("HREmployeeOffWorks")]
    public class HREmployeeOffWorks : FixFiveProps
    {
        [Key]
        public int HREmployeeOffWorkID { get; set; }
        public int FK_HREmployeeID { get; set; }
        public Nullable<DateTime> HREmployeeOffWorkFromDate { get; set; }
        public Nullable<DateTime> HREmployeeOffWorkToDate { get; set; }
        public string HREmployeeOffWorkTypeCombo { get; set; } = string.Empty;
        public string HREmployeeOffWorkApproveUser { get; set; } = string.Empty;
        public string HREmployeeOffWorkReasonDetail { get; set; } = string.Empty;
        public Boolean HREmployeeOffWorkIsApprove { get; set; } = true;
        public decimal HREmployeeOffWorkDay { get; set; }
        public decimal HREmployeeActualOffWorkDay { get; set; }
        public int FK_HREmployeeLeaveTypeID { get; set; }
        public Nullable<DateTime> HREmployeeOffWorkCreateDate { get; set; } = DateTime.Now;
        public string HREmployeeOffWorkApprovedPerson { get; set; } = string.Empty;
        public int HREmployeeOffWorkPeriod { get; set; }
        public int HREmployeeOffWorkFiscalYear { get; set; }
        public decimal HREmployeeOffWorkRegDays { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_HRPositionID { get; set; }
        public int FK_HRSectionID { get; set; }
        public string HREmployeeOffWorkNote { get; set; } = string.Empty;
        public string HREmployeeOffWorkStatus { get; set; } = string.Empty;
        public string HREmployeeOffWorkUnApproveReason { get; set; } = string.Empty;
        public string ApprovalStatusCombo { get; set; } = "New";
        public string HREmployeeOffWorkCancelReason { get; set; } = string.Empty;
        public Nullable<DateTime> HREmployeeOffWorkCancelDate { get; set; }
        public string HREmployeeOffWorkCancelUser { get; set; } = string.Empty;
        public string HREmployeeOffWorkReadUsers { get; set; } = string.Empty;
        public int FK_ADApprovalProcID { get; set; }
        public string HREmployeeOffWorkNo { get; set; } = string.Empty;
        public bool HREmployeeOffWorkNotDilCheck { get; set; } = false;
    }
}
