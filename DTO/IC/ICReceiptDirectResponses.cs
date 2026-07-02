using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceiptDirectResponses : NumberRecord
    {
            [JsonPropertyName("id")]
            public int ICReceiptID { get; set; }
            [JsonPropertyName("no")]
            public string ICReceiptNo { get; set; }
            [JsonPropertyName("receiptDate")]
            public Nullable<DateTime> ICReceiptDate { get; set; }
            [JsonPropertyName("nccId")]
            public int FK_APSupplierID { get; set; }
            [JsonPropertyName("fk_transConfig")]
            public int FK_GLTranCfgID { get; set; }
            [JsonPropertyName("fk_stock")]
            public int FK_ICStockID { get; set; }
            [JsonPropertyName("description")]
            public string ICReceiptDesc { get; set; }
            [JsonPropertyName("status")]
            public string ICReceiptStatusCombo { get; set; }

            [JsonPropertyName("fk_branch")]
            public int FK_BRBranchID { get; set; }

            [JsonPropertyName("fk_currency")]
            public int FK_GECurrencyID { get; set; }

            [JsonPropertyName("employeeId")]
            public int FK_HREmployeeID { get; set; }
            [JsonPropertyName("excRate")]
            public decimal ICReceiptExcRate { get; set; }
    }
}
