using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceiptKQSXResponses : NumberRecord
    {
       // [JsonPropertyName("id")]
        public int ICReceiptID { get; set; }
     //   [JsonPropertyName("no")]
        public string ICReceiptNo { get; set; }

     //   [JsonPropertyName("receiptDate")]
        public Nullable<DateTime> ICReceiptDate { get; set; }
       // [JsonPropertyName("fk_stock")]
        public int FK_ICStockID { get; set; }
      //  [JsonPropertyName("description")]
        public string ICReceiptDesc { get; set; }
      //  [JsonPropertyName("postStatus")]
        public string AAPostStatus { get; set; }
      //  [JsonPropertyName("status")]
        public string ICReceiptStatusCombo { get; set; }

      //  [JsonPropertyName("fk_branch")]
        public int FK_BRBranchID { get; set; }
    //    [JsonPropertyName("prodOrderName")]
        public string PPProductionOrdrName { get; set; }

     //   [JsonPropertyName("fk_currency")]
        public int FK_GECurrencyID { get; set; }
       // [JsonPropertyName("transConfigName")]
        public string GLTranCfgName { get; set; }
      //  [JsonPropertyName("fk_transConfig")]
        public int FK_GLTranCfgID { get; set; }

     //   [JsonPropertyName("fk_employee")]
        public int FK_HREmployeeID { get; set; }
      //  [JsonPropertyName("excRate")]
        public decimal ICReceiptExcRate { get; set; }
        public string PPWONo { get; set; }
        public string PPProductionOrdrNo { get; set; }
    }
}
