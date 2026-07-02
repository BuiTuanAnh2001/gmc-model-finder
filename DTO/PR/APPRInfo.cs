using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PR
{
    public class APPRInfo : NumberRecord
    {
        [JsonPropertyName("hremployeeNo")]
        public string employeeNo { get; set; }

        [JsonPropertyName("hremployeeName")]
        public string employeeFullName { get; set; }
        [JsonPropertyName("apsupplierName")]
        public string nccName { get; set; }
        public int FK_APSupplierID { get; set; }
      //  [JsonPropertyName("id")]
        public int APPRID { get; set; }
      //  [JsonPropertyName("no")]
        public string APPRNo { get; set; }
    //    [JsonPropertyName("apprDate")]
        public Nullable<DateTime> APPRDate { get; set; }
    //    [JsonPropertyName("description")]
        public string APPRDesc { get; set; }

     //   [JsonPropertyName("lc_status")]
        public string ApprovalStatusCombo { get; set; } = "New";
    //    [JsonPropertyName("procStepId")]
        public int FK_ADApprovalProcStepID { get; set; } = 0;
        public int FK_BRBranchID { get; set; }
     //   [JsonPropertyName("inboxId")]
        public int ADInboxItemID { get; set; } = 0;
        public int displayReject { get; set; } = 0;
        public string AACreatedUser { get; set; }
        public int FK_GECurrencyID { get; set; }
    }
}
