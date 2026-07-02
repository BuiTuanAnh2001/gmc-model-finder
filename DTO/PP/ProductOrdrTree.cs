using gmc_api.Base.Helpers;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class ProductOrdrTree
    {
        public int PPProductionOrdrID { get; set; }
      //  [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
      //  [JsonPropertyName("name")]
        public string PPProductionOrdrName { get; set; }
        public int FK_PPPhaseCfgID {get;set;}
    //    [JsonPropertyName("phaseName")]
        public string PPPhaseCfgName { get; set; }
     //   [JsonPropertyName("productDate")]
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
     //   [JsonPropertyName("desc")]
        public string PPProductionOrdrDesc { get; set; }
        [JsonPropertyName("paramStatus")]
        public string paramStatus { get; set; }
        public string PPWONo { get; set; }
        public string PPWOName { get; set; }
        public string PPWorkCenterName { get; set; }
        public string PPPhaseCfgNo { get; set; }
        [JsonPropertyName("jobticketStatus")]
        public string jobticketStatus { get; set; }
      //  [JsonPropertyName("status")]
        public string PPProductionOrdrStatus { get; set; }
     //   [JsonPropertyName("qcStatus")]
        public string PPProductionOrdrQCStatusCombo { get; set; }
     //   [JsonPropertyName("rmStatus")]
        public string PPProductionOrdrRMStatusCombo { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public string ICProductCodes { get; set; }
        public string tof05Name { get; set; }
        public string jobTicketNo { get; set; }
        public int FK_PPWOPlanID { get; set; }
        public string PPPhaseCfgGroupNo { get; set; }
        public string PPPhaseCfgGroupName { get; set; }
        public string AACreatedUser { get; set; }
       public int FK_GLTranCfgID { get; set; }

        public string AAStatus { get; set; }
        public string AAUpdatedUser { get; set; } = String.Empty;
        public Nullable<DateTime> AACreatedDate { get; set; }
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public string AAPostStatus { get; set; }
        public string AALastPostNo { get; set; } = String.Empty;
        public Nullable<DateTime> AALastPostDate { get; set; }

        public Nullable<DateTime> PPProductionOrdrEstDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrActDate { get; set; }
        public int FK_HREmployeeID { get; set; }
        public int FK_PPWOID { get; set; }
        //public int FK_ICFromStockID { get; set; }
        //public int FK_ICToStockID { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstStartDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrEstEndDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrActStartDate { get; set; }
        public Nullable<DateTime> PPProductionOrdrActEndDate { get; set; }
        public string PPProductionOrdrTypeCombo { get; set; } = String.Empty;
        public string PPProductionOrdrLotNo { get; set; } = String.Empty;
        public Boolean AASelected { get; set; }
        //public string AACompanyTypeCombo { get; set; } = String.Empty;
        //public string AAOrgDocNo { get; set; } = String.Empty;
        public int FK_PPProductionOrdrParentID { get; set; }
        public int FK_PPWorkCenterID { get; set; }
        public int FK_PPResourceID { get; set; }
        public Nullable<DateTime> PPProductionOrdrJrnDate { get; set; }
        public int FK_BRBranchID { get; set; }
        public string PPProductionOrdrConvertTypeCombo { get; set; } = String.Empty;
        public int FK_PPPrdQCID { get; set; }
        public string PPProductionOrdrJrnNo { get; set; } = String.Empty;
        public int FK_ICConvertProductID { get; set; }
        public string PPProductionOrdrGroupCombo { get; set; } = String.Empty;
        public int FK_HRMachineID { get; set; }
        public int FK_ICProductRootID { get; set; }
        public Nullable<DateTime> PPProductionOrdrCloseDate { get; set; }
        public string PPProductionOrdrCStatusCombo { get; set; }
        //   public string PPProductionOrdrResourceParamStatusCombo { get; set; }
        //public int FK_HRDepartmentID { get; set; }
        //public int FK_HRSectionID { get; set; }
        //public int FK_PPLineID { get; set; }
        //public int FK_PPLineProcesID { get; set; }
        //public int FK_PPPhaseCfgGroupID { get; set; }
    }
}
