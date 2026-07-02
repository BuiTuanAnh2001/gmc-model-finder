using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class KQSXItemReceiptInfo
    {
        [JsonPropertyName("itemId")]
        public int PPProductionOrdrEstFGID { get; set; }
        [JsonPropertyName("productId")]
        public int ICProductID { get; set; }

        [JsonPropertyName("itemNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("itemName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("stockName")]
        public string stockName { get; set; }
        [JsonPropertyName("phaseNo")]
        public string phaseNo { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
        [JsonPropertyName("numberOutProductQty")]
        public decimal PPProductionOrdrEstFGMFQty { get; set; }
        [JsonPropertyName("itemRQty")]
        public decimal PPProductionOrdrEstFGRQty { get; set; }
        [JsonPropertyName("units")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("unitStk")]
        public string ICStkUOMName { get; set; }
        [JsonPropertyName("lotNo")]
        public string lotNo { get; set; }
        [JsonPropertyName("barcodeNo")]
        public string barcodeNo { get; set; }
        [JsonPropertyName("factor")]
        public decimal PPProductionOrdrEstFGFact { get; set; }
        [JsonPropertyName("serialNo")]
        public string PPProductionOrdrEstFGSerialNo { get; set; }

    }
}
