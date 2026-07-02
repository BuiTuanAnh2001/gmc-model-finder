using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceiptItemResponses
    {
        [JsonPropertyName("id")]
        public int ICReceiptItemID { get; set; }
        [JsonPropertyName("productId")]
        public int productId { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("units")]
        public string units { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStk")]
        public string unitStk { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("stockName")]
        public string stockName { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("lotNo")]
        public string ICReceiptItemLotNo { get; set; }
        [JsonPropertyName("fglotNo")]
        public string ICReceiptItemFGLotNo { get; set; }
        [JsonPropertyName("barcodeNo")]
        public string ICReceiptItemBarCodeNo { get; set; }
        [JsonPropertyName("qty")]
        public decimal ICReceiptItemQty { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICReceiptItemStkQty { get; set; }
        [JsonPropertyName("description")]
        public string ICReceiptItemDesc { get; set; }
        [JsonPropertyName("costCenter")]
        public int FK_PPCostCenterID { get; set; }
        public string PPPhaseCfgNo { get; set; }
        public string PPPhaseCfgName { get; set; }
        public string PPProductionOrdrNo { get; set; }
        public string PPWONo { get; set; }
        public decimal ICReceiptItemFact { get; set; }
        public int FK_PPPhaseCfgID { get; set; }
        public int FK_PPProductionOrdrID { get; set; }
        public byte[] ICReceiptItemBarCode { get; set; }
        public Nullable<DateTime> ICReceiptItemExpireDate { get; set; }
        public string ICReceiptItemSerialNo { get; set; }
        public int FK_ICRequestReceiptID { get; set; }
        public int FK_ICReceiptID { get; set; }
       public int FK_GLCreditAccountID { get; set; }
        public decimal ICReceiptItemBarQty { get; set; }
    }
}
