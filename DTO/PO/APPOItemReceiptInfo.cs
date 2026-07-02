using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class APPOItemReceiptInfo
    {
        [JsonPropertyName("itemId")]
        public int APPOItemID { get; set; }
        [JsonPropertyName("productId")]
        public int ICProductID { get; set; }

        [JsonPropertyName("itemNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("itemName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("itemQty")]
        public decimal APPOItemQty { get; set; }
        [JsonPropertyName("itemRQty")]
        public decimal APPOItemRcpRQty { get; set; }
        [JsonPropertyName("units")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStk")]
        public string ICUOMNameStk { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
        [JsonPropertyName("lotNo")]
        public string lotNo { get; set; }
        [JsonPropertyName("barcodeNo")]
        public string barcodeNo { get; set; }
        [JsonPropertyName("descriptions")]
        public string descriptions { get; set; }
        [JsonPropertyName("factor")]
        public decimal APPOItemFact { get; set; }
        [JsonPropertyName("adjStkQty")]
        public decimal APPOItemAdjStkQty { get; set; }

    }
}
