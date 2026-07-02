using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceiptDataUpdate
    {
        [JsonPropertyName("id")]
        public int ICReceiptID { get; set; }
        [JsonPropertyName("no")]
        public string ICReceiptNo { get; set; }
        [JsonPropertyName("fk_supplier")]
        public int FK_APSupplierID { get; set; }
        [JsonPropertyName("customerId")]
        public int FK_ARCustomerID { get; set; }
       [JsonPropertyName("fk_transConfig")]
        public int FK_GLTranCfgID { get; set; }
        [JsonPropertyName("fk_stock")]
        public int FK_ICStockID { get; set; }
        //[JsonPropertyName("receiptDate")]
        //public Nullable<DateTime> ICReceiptDate { get; set; }
        [JsonPropertyName("description")]
        public string ICReceiptDesc { get; set; }
        [JsonPropertyName("fk_branch")]
        public int FK_BRBranchID { get; set; }
        [JsonPropertyName("fk_employee")]
        public int FK_HREmployeeID { get; set; }
        
    }
}
