using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class KQSXItemShipmentInfo
    {
        [JsonPropertyName("stockId")]
        public int stockId { get; set; }
        [JsonPropertyName("itemId")]
        public int PPProductionOrdrEstRMID { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("lotNo")]
        public string PPProductionOrdrEstRMLotNo { get; set; }
        [JsonPropertyName("itemRQty")]
        public decimal PPProductionOrdrEstRMRQty { get; set; }
        [JsonPropertyName("jobticketQty")]
        public decimal PPProductionOrdrEstRMQty { get; set; }
        [JsonPropertyName("fgProductId")]
        public int FK_ICFGProductID { get; set; }
        [JsonPropertyName("fgProductNo")]
        public string fgProductNo { get; set; }
        [JsonPropertyName("fgProductName")]
        public string fgProductName { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
        [JsonPropertyName("fgLotNo")]
        public string PPProductionOrdrEstRMFGLotNo { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("factor")]
        public decimal PPProductionOrdrEstRMFact { get; set; }
        [JsonPropertyName("adjStkQty")]
        public decimal adjStkQty { get; set; } = 0;
        [JsonPropertyName("serialNo")]
        public string PPProductionOrdrEstRMSerialNo { get; set; }
    }
}
