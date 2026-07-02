using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Shipment
{
    public class ICShipmentItemResponses
    {
        [JsonPropertyName("id")]
        public int ICShipmentItemID { get; set; }
        [JsonPropertyName("description")]
        public string ICShipmentItemDesc { get; set; }

        [JsonPropertyName("productId")]
        public int productId { get; set; }

        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("productWoName")]
        public string productWoName { get; set; }
        [JsonPropertyName("productWoNo")]
        public string productWoNo { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("fk_stockSlot")]
        public int FK_ICStockSlotID { get; set; }
        [JsonPropertyName("qty")]
        public decimal ICShipmentItemQty { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICShipmentItemStkQty { get; set; }
        [JsonPropertyName("fgLotNo")]
        public string ICShipmentItemFGLotNo { get; set; }
        [JsonPropertyName("lotNo")]
        public string ICShipmentItemLotNo { get; set; }
        [JsonPropertyName("fact")]
        public decimal ICShipmentItemFact { get; set; }
        [JsonPropertyName("phaseCfgId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("shipmentid")]
        public int FK_ICShipmentID { get; set; }
        public int FK_PPCostCenterID { get; set; }
        public string PPCostCenterNo { get; set; }
        public string PPCostCenterName { get; set; }
        public string ARSONo { get; set; }
        public int FK_PPProductionOrdrRelationID { get; set; }
        public int FK_ICROID { get; set; }
        public decimal ICShipmentItemBarQty { get; set; }
    }
}
