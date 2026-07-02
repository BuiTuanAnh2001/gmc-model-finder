using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Inventoty
{
    public class ViewInventoryStockLotNos
    {
        [JsonPropertyName("itemId")]
        public int ViewInventoryStockLotNoID { get; set; }
        public string AAStatus { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; }
        [JsonPropertyName("LotNo")]
        public string ICInventoryStockLotNoProductLotNo { get; set; }
        [JsonPropertyName("qty")]
        public decimal ICInventoryStockLotNoQuantity { get; set; }
        public decimal ICInventoryStockLotNoProposalQuantity { get; set; }
        public decimal ViewInventoryStockLotNosaleOrderQuantity { get; set; }
        public decimal ICInventoryStockLotNoPurchaseOrderQuantity { get; set; }
        [JsonPropertyName("seleted")]
        public Boolean AASelected { get; set; }
        [JsonPropertyName("shipQty")]
        public decimal ViewInventoryStockLotNoShpQty { get; set; }
        public Nullable<DateTime> ViewInventoryStockLotNoExpireDate { get; set; }
        public Boolean ViewInventoryStockLotNoIsExpired { get; set; }
        [JsonPropertyName("stockSlotId")]
        public int FK_ICStockSlotID { get; set; }
        public Nullable<DateTime> ViewInventoryStockLotNoDate { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        public decimal ViewInventoryStockLotNoShpStkQty { get; set; }
        [JsonPropertyName("fact")]
        public decimal ViewInventoryStockLotNoFact { get; set; }
        [JsonPropertyName("aviQty")]
        public decimal ViewInventoryStockLotNoBalanceQty { get; set; }
        [JsonPropertyName("reserve")] 
        public decimal ViewInventoryStockLotNoAllocateQty { get; set; }

    }
}
