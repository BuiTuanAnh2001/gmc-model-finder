using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Transfer
{
    public class ICTranserItemResponses
    {
        [JsonPropertyName("itemId")]
        public int ICTransferItemID { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("oldCode")]
        public string ICProductCodes { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal ICTransferItemQty { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICTransferItemStkQty { get; set; }
        [JsonPropertyName("unitStockId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("fact")]
        public decimal ICTransferItemFact { get; set; }
        [JsonPropertyName("lotNo")]
        public string ICTransferItemLotNo { get; set; }
        [JsonPropertyName("barCode")]
        public string ICTransferItemBarCodeNo { get; set; }
        [JsonPropertyName("fromStkId")]
        public int FK_ICFromStockID { get; set; }
        [JsonPropertyName("toStkId")]
        public int FK_ICToStockID { get; set; }
        [JsonPropertyName("invQty")]
        public decimal ICTransferItemInvQty { get; set; }
        [JsonPropertyName("fgLotNo")]
        public string ICTransferItemFGLotNo { get; set; }
        [JsonPropertyName("description")]
        public string ICTransferItemDesc { get; set; }
        [JsonPropertyName("transferId")]
        public int FK_ICTransferID { get; set; }
       

    }
}
