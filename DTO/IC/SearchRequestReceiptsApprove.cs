using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class SearchRequestReceiptsApprove
    {
      //  [JsonPropertyName("id")]
        public int ICRequestReceiptID { get; set; }
      //  [JsonPropertyName("no")]
        public string ICRequestReceiptNo { get; set; }
     //   [JsonPropertyName("date")]
        public Nullable<DateTime> ICRequestReceiptDate { get; set; }
      //  [JsonPropertyName("desc")]
        public string ICRequestReceiptDesc { get; set; }
        //[JsonPropertyName("approvalstatus")]
        //public string ApprovalStatusCombo { get; set; }
      //  [JsonPropertyName("stockid")]
        public int FK_ICStockID { get; set; }
      //  [JsonPropertyName("stockno")]
        public string ICStockNo { get; set; }
      //  [JsonPropertyName("stockname")]
        public string ICStockName { get; set; }
        public string ApprovalStatusCombo { get; set; } = "New";
      //  [JsonPropertyName("procStepId")]
        public int FK_ADApprovalProcStepID { get; set; } = 0;
      //  [JsonPropertyName("inboxId")]
        public int ADInboxItemID { get; set; } = 0;
        public int displayReject { get; set; } = 0;

        [JsonPropertyName("hremployeeNo")]
        public string employeeNo { get; set; }

        [JsonPropertyName("hremployeeName")]
        public string employeeFullName { get; set; }
        public string PPProductionOrdrNo { get; set;}
    }
}
