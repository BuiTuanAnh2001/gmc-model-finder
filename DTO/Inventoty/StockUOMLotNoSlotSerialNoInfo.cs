using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class StockUOMLotNoSlotSerialNoInfo
    {
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; } = 0;
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; } = 0;
        [JsonPropertyName("productType")]
        public int FK_ICProductTypeID { get; set; } = 0;
        [JsonPropertyName("productGroupType")]
        public int FK_ICProductGroupID { get; set; } = 0;
        [JsonPropertyName("stockType")]
        public int FK_ICStockTypeID { get; set; } = 0;
        [JsonPropertyName("prdDimention1")]
        public int FK_ICProductDimention1ID { get; set; } = 0;
        [JsonPropertyName("prdDimention2")]
        public int FK_ICProductDimention2ID { get; set; } = 0;
        [JsonPropertyName("prdDimention3")]
        public int FK_ICProductDimention3ID { get; set; } = 0;
        [JsonPropertyName("prdDimention4")]
        public int FK_ICProductDimention4ID { get; set; } = 0;
        [JsonPropertyName("prdDimention5")]
        public int FK_ICProductDimention5ID { get; set; } = 0;
        [JsonPropertyName("stockSlotId")]
        public int FK_ICStockSlotID { get; set; } = 0;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = DateTime.Now;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime>  toDate { get; set; } = DateTime.Now;
        [JsonPropertyName("serialNo")]
        public string ICShipmentItemSerialNo { get; set; } = string.Empty;
        [JsonPropertyName("lotNo")]
        public string ICShipmentItemLotNo { get; set; } = string.Empty;
    }
    public class TrackLotNoDetail
    {
        public int IndexCheck { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public decimal TrackLotNoQty { get; set; }
        public decimal TrackLotNoStkQty { get; set; }
        public decimal TrackLotNoFact { get; set; }
        public decimal TrackLotNoOldQty { get; set; }
        public String TrackLotNoLotNo { get; set; } = string.Empty;
        public String TrackLotNoPOF01Combo { get; set; } = string.Empty;
        public String TrackLotNoPOF02Combo { get; set; } = string.Empty;
        public String TrackLotNoPOF03Combo { get; set; } = string.Empty;
        public String TrackLotNoPOF04Combo { get; set; } = string.Empty;
        public String TrackLotNoPOF05Combo { get; set; } = string.Empty;
        public String TrackLotNoSerialNo { get; set; } = string.Empty;
        public int FK_ICUOMID { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public DateTime TrackLotNoInvDate { get; set; }
    }
    public class TrackLotnoInventoryStockLotNos
    {
        public int ViewInventoryStockLotNoID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public String ICInventoryStockLotNoProductLotNo { get; set; } = string.Empty;
        public String ICInventoryStockLotNoPOF01Combo { get; set; } = string.Empty;
        public String ICInventoryStockLotNoPOF02Combo { get; set; } = string.Empty;
        public String ICInventoryStockLotNoPOF03Combo { get; set; } = string.Empty;
        public String ICInventoryStockLotNoPOF04Combo { get; set; } = string.Empty;
        public String ICInventoryStockLotNoPOF05Combo { get; set; } = string.Empty;
        public decimal ICInventoryStockLotNoQuantity { get; set; }
        public decimal ICInventoryStockLotNoProposalQuantity { get; set; }
        public decimal ViewInventoryStockLotNosaleOrderQuantity { get; set; }
        public decimal ICInventoryStockLotNoPurchaseOrderQuantity { get; set; }
        public bool AASelected { get; set; }
        public decimal ViewInventoryStockLotNoShpQty { get; set; }
        public Nullable<DateTime> ViewInventoryStockLotNoExpireDate { get; set; }
        public bool ViewInventoryStockLotNoIsExpired { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public Nullable<DateTime> ViewInventoryStockLotNoDate { get; set; }
        public int FK_ICUOMID { get; set; }
        public decimal ViewInventoryStockLotNoShpStkQty { get; set; }
        public decimal ViewInventoryStockLotNoFact { get; set; }
        public decimal ViewInventoryStockLotNoBalanceQty { get; set; }
        public decimal ViewInventoryStockLotNoAllocateQty { get; set; }
        public String ICInventoryStockLotNoProductSerialNo { get; set; } = string.Empty;
        public decimal ICInventoryStockLotNoStkQuantity { get; set; }
        public int FK_ICStkUOMID { get; set; }
    }
}
