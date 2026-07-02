using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Transfer
{
    public class ICTranferResponses : NumberRecord
    {
        //ICTransfer
      //  [JsonPropertyName("id")]
        public int ICTransferID { get; set; }
     //   [JsonPropertyName("no")]
        public string ICTransferNo { get; set; }
       // [JsonPropertyName("description")]
        public string ICTransferDesc{ get; set; }
       // [JsonPropertyName("transferDate")]
        public Nullable<DateTime> ICTransferDate { get; set; }
     //   [JsonPropertyName("fromStkId")]
        public int FK_ICFromStockID { get; set; }
     //   [JsonPropertyName("toStkId")]
        public int FK_ICToStockID { get; set; }
    //    [JsonPropertyName("status")]
        public string ICTransferStatusCombo { get; set; }
     //   [JsonPropertyName("ref")]
        public string ICTransferRef { get; set; }
     //   [JsonPropertyName("fk_wo")]
        public int FK_PPWOID { get; set; }
     //   [JsonPropertyName("woNo")]
        public string PPWONo { get; set; }
     //   [JsonPropertyName("typeCombo")]
        public string ICTransferTypeCombo { get; set; }
       // [JsonPropertyName("tranCfgId")]
        public int FK_GLTranCfgID { get; set; }
     //   [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; }
    //    [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        public string listROID { get; set; }
        public string PPProductionOrdrNo { get; set; }
    }
}
