using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class APPOInfo : NumberRecord
    {
        [JsonPropertyName("hremployeeNo")]
        public string employeeNo { get; set; }

        [JsonPropertyName("hremployeeName")]
        public string employeeFullName { get; set; }
        [JsonPropertyName("apsupplierName")]
        public string nccName { get; set; }
        public int FK_APSupplierID { get; set; }
     //   [JsonPropertyName("id")]
        public int APPOID { get; set; }
    //    [JsonPropertyName("no")]
        public string APPONo { get; set; }
      //  [JsonPropertyName("apprDate")]
        public Nullable<DateTime> APPODate { get; set; }
      //  [JsonPropertyName("description")]
        public string APPODesc { get; set; }
      //  [JsonPropertyName("summary")]
        public decimal APPOAmtTot { get; set; }

      //  [JsonPropertyName("lc_status")]
        public string ApprovalStatusCombo { get; set; } = "New";
     //   [JsonPropertyName("procStepId")]
        public int FK_ADApprovalProcStepID { get; set; } = 0;
    //    [JsonPropertyName("inboxId")]
        public int ADInboxItemID { get; set; } = 0;
        public int displayReject { get; set; } = 0;
        public string APPOTypeCombo {get;set;}
        public string AACreatedUser { get; set; }
        public int FK_GECurrencyID { get; set; }
        public string AAModule { get; set; }
    }
}
