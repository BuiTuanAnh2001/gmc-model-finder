using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARSOInfo : NumberRecord
    {
        [JsonPropertyName("hremployeeNo")]
        public string employeeNo { get; set; }

        [JsonPropertyName("hremployeeName")]
        public string employeeFullName { get; set; }
        public int FK_HREmployeeID { get; set; }

        //   [JsonPropertyName("id")]
        public int ARSOID { get; set; }
        //   [JsonPropertyName("no")]
        public string ARSONo { get; set; }
        //   [JsonPropertyName("sendDate")]
        public Nullable<DateTime> ARSODate { get; set; }
        //   [JsonPropertyName("description")]
        public string ARSODesc { get; set; }
        public int FK_ARCustomerID {get;set;}
        // [JsonPropertyName("customer")]
        public string ARCustomerName { get; set; }
       // [JsonPropertyName("summaryF")]
        public decimal ARSOFAmtTot { get; set; }
     //   [JsonPropertyName("summary")]
        public decimal ARSOAmtTot { get; set; }
      //  [JsonPropertyName("lc_status")]
        public string ApprovalStatusCombo { get; set; } = "New";
      //  [JsonPropertyName("procStepId")]
        public int FK_ADApprovalProcStepID { get; set; } = 0;
      //  [JsonPropertyName("inboxId")]
        public int ADInboxItemID { get; set; } = 0;
        public int displayReject { get; set; } = 0;
        public string AACreatedUser { get; set; }
        public int FK_GECurrencyID { get; set; }
        public int FK_ARSellerID { get; set; }
        public int FK_BRBranchID { get; set; }
    }
}
