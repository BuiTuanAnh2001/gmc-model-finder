using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Shipment
{
    public class ICShipmentResponses : NumberRecord
    {
        
     //   [JsonPropertyName("id")]
        public int ICShipmentID { get; set; }
     //   [JsonPropertyName("no")]
        public string ICShipmentNo { get; set; }
     //   [JsonPropertyName("description")]
        public string ICShipmentDesc { get; set; }
     //   [JsonPropertyName("fk_branch")]
        public int FK_BRBranchID { get; set; }
     //   [JsonPropertyName("status")]
        public string ICShipmentStatusCombo { get; set; }

     //   [JsonPropertyName("fk_stock")]
        public int FK_ICStockID { get; set; }
      //  [JsonPropertyName("fk_customer")]
        public int FK_ARCustomerID { get; set; }

     //   [JsonPropertyName("shipmentDate")]
        public Nullable<DateTime> ICShipmentDate { get; set; }
     //   [JsonPropertyName("fk_transConfig")]
        public int FK_GLTranCfgID { get; set; }
     //   [JsonPropertyName("address")]
        public string ICShipmentSTAddL1 { get; set; }
     //   [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
     //   [JsonPropertyName("destination")]
        public string ICShipmentDestination { get; set; }
    //    [JsonPropertyName("excRate")]
        public decimal ICShipmentExcRate { get; set; }
     //   [JsonPropertyName("fk_currency")]
        public int FK_GECurrencyID { get; set; }
    //    [JsonPropertyName("shipmentTypeId")]
        public int FK_ICShipmentTypeID { get; set; }
    //    [JsonPropertyName("approvalStatusCombo")]
        public string ApprovalStatusCombo { get; set; }
        public string PPWONo { get; set; }
        public string PPProductionOrdrNo { get; set; }
        public string ARSONo { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
    }
}
