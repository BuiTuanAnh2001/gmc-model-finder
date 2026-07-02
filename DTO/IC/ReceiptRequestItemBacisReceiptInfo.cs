using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ReceiptRequestItemBacisReceiptInfo
    {
        [JsonPropertyName("itemId")]
        public int ICRequestReceiptItemID { get; set; }
        [JsonPropertyName("productId")]
        public int productId { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("itemQty")]
        public decimal ICRequestReceiptItemQty { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
        [JsonPropertyName("itemRQty")]
        public decimal ICRequestReceiptItemRQty { get; set; }
        [JsonPropertyName("itemStockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("itemOrgQty")]
        public decimal ICRequestReceiptItemOrgQty { get; set; }
        [JsonPropertyName("factor")]
        public decimal ICRequestReceiptItemFact { get; set; }
        [JsonPropertyName("adjStkQty")]
        public decimal ICRequestReceiptItemAdjStkQty { get; set; }
        [JsonPropertyName("descriptions")]
        public string descriptions { get; set; }
        [JsonPropertyName("lotNo")]
        public string lotNo { get; set; }
        [JsonPropertyName("barcodeNo")]
        public string barcodeNo { get; set; }
        [JsonPropertyName("costCenter")]
        public int FK_PPCostCenterID { get; set; }
        [JsonPropertyName("fglotNo")]
        public string ICRequestReceiptItemFGLotNo { get; set; }
        public string ICRequestReceiptItemSerialNo { get; set; }

    }
}
