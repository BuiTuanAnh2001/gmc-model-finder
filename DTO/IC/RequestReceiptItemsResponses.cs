using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class RequestReceiptItemsResponses
    {
        [JsonPropertyName("itemid")]
        public int ICRequestReceiptItemID { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("productNo")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("productName")]
        public string ICProductName { get; set; }
        [JsonPropertyName("oldCode")]
        public string ICProductCodes { get; set; }
        [JsonPropertyName("lotNo")]
        public string ICRequestReceiptItemLotNo { get; set; }
        [JsonPropertyName("qty")]
        public decimal ICRequestReceiptItemQty { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICRequestReceiptItemStkQty { get; set; }
        [JsonPropertyName("uomNo")]
        public string ICUOMNo { get; set; }
        [JsonPropertyName("uomName")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("stockno")]
        public string ICStockNo { get; set; }
        [JsonPropertyName("stockname")]
        public string ICStockName { get; set; }

        [JsonPropertyName("comment")]
        public string ICRequestReceiptItemComment { get; set; }
        [JsonPropertyName("desc")]
        public string ICRequestReceiptItemDesc { get; set; }
    }
}
