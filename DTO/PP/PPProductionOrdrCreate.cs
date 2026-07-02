using System;

namespace gmc_api.DTO.PP
{
    public class PPProductionOrdrCreate
    {
        public int PPProductionOrdrID { get; set; }
        public String AAPostStatus { get; set; } = "New";
        public String AALastPostNo { get; set; } = string.Empty;
        public Nullable<DateTime> AALastPostDate { get; set; }
        public String PPProductionOrdrNo { get; set; } = string.Empty;
        public String PPProductionOrdrName { get; set; } = string.Empty;
        public String PPProductionOrdrDesc { get; set; } = string.Empty;
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        public String PPProductionOrdrStatus { get; set; } = "New";
        public Nullable<DateTime> PPProductionOrdrEstDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrActDate { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_ICFromStockID { get; set; }
        public int FK_ICToStockID;
        public Nullable<DateTime> PPProductionOrdrEstStartDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstEndDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrActStartDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrActEndDate { get; set; }
        public String PPProductionOrdrTypeCombo { get; set; } = string.Empty;
        public String PPProductionOrdrLotNo { get; set; } = string.Empty;
        public bool AASelected { get; set; } = true;
        public String AACompanyTypeCombo { get; set; } = string.Empty;
        public String AAOrgDocNo { get; set; } = string.Empty;
        public int FK_PPProductionOrdrParentID { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_PPResourceID { get; set; }
        public Nullable<DateTime> PPProductionOrdrJrnDate { get; set; }
        public int FK_BRBranchID { get; set; }
        public String PPProductionOrdrConvertTypeCombo { get; set; } = string.Empty;
        public int FK_PPPrdQCID { get; set; }
        public String PPProductionOrdrJrnNo { get; set; } = string.Empty;
        public int FK_GLTranCfgID { get; set; }
        public int FK_ICConvertProductID { get; set; }
        public String PPProductionOrdrGroupCombo { get; set; }
        public int FK_HRMachineID { get; set; }
        public int FK_ICProductRootID { get; set; }
        public Nullable<DateTime> PPProductionOrdrCloseDate { get; set; }
        public string PPProductionOrdrQCStatusCombo { get; set; } = "New";
        public string PPProductionOrdrCStatusCombo { get; set; } = "New";
    }
}
