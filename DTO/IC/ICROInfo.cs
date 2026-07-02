using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.RO
{
    public class ICROInfo : NumberRecord
    {
        [JsonPropertyName("hremployeeNo")]
        public string employeeNo { get; set; }

        [JsonPropertyName("hremployeeName")]
        public string employeeFullName { get; set; }

      //  [JsonPropertyName("id")]
        public int ICROID { get; set; }
       // [JsonPropertyName("no")]
        public string ICRONo { get; set; }
        // [JsonPropertyName("date")]
        public Nullable<DateTime> ICRODate { get; set; }
        //[JsonPropertyName("description")]
        public string ICRODesc { get; set; }
        public int FK_PPWOID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
       public string PPWONo { get; set; }
        public string PPProductionOrdrNo { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICStockNo { get; set; }
        public string ICStockName { get; set; }
        public int FK_BRBranchID { get; set; }
        public string BRBranchNo { get; set; }
        public string BRBranchName { get; set; }
      //  [JsonPropertyName("summaryF")]
        public decimal ICROFAmtTot { get; set; }
     //   [JsonPropertyName("summary")]
        public decimal ICROAmtTot { get; set; }
      //  [JsonPropertyName("lc_status")]
        public string ApprovalStatusCombo { get; set; } = "New";
        //[JsonPropertyName("procStepId")]
        public int FK_ADApprovalProcStepID { get; set; } = 0;
       // [JsonPropertyName("inboxId")]
        public int ADInboxItemID { get; set; } = 0;
        public int displayReject { get; set; } = 0;
    }
}
