using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceiptResponses : NumberRecord
    {
      //  [JsonPropertyName("id")]
        public int ICReceiptID { get; set; }
      //  [JsonPropertyName("no")]
        public string ICReceiptNo { get; set; }
     //   [JsonPropertyName("status")]
        public string ICReceiptStatusCombo { get; set; }
        public string AAPostStatus { get; set; }
      //  [JsonPropertyName("fk_supplier")]
        public int FK_APSupplierID { get; set; }
     //   [JsonPropertyName("customerId")]
        public int FK_ARCustomerID { get; set; }
      //  [JsonPropertyName("fk_currency")]
        public int FK_GECurrencyID { get; set; }
      //  [JsonPropertyName("fk_transConfig")]
        public int FK_GLTranCfgID { get; set; }
      //  [JsonPropertyName("fk_stock")]
        public int FK_ICStockID { get; set; }
      //  [JsonPropertyName("totalAmt")]
        public decimal ICReceiptAmtTot { get; set; }
     //   [JsonPropertyName("tax")]
        public decimal ICReceiptTxAmtTot { get; set; }
      //  [JsonPropertyName("receiptDate")]
        public Nullable<DateTime> ICReceiptDate { get; set; }
     //   [JsonPropertyName("description")]
        public string ICReceiptDesc { get; set; }

      //  [JsonPropertyName("fk_branch")]
        public int FK_BRBranchID { get; set; }
      //  [JsonPropertyName("fk_employee")]
        public int FK_HREmployeeID { get; set; }
     //   [JsonPropertyName("excRate")]
        public decimal ICReceiptExcRate { get; set; }
        public string PPWONo { get; set; }
		public string PPProductionOrdrNo { get; set;}
        public int FK_APPOID { get; set; }
    }
}
