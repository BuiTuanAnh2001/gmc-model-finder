using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROItemForShipment
    {        
        [JsonPropertyName("stockId")]
        public int stockId { get; set; }
        [JsonPropertyName("stockSlotId")]
        public int stockSlotId { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("itemId")]
        public int ICROItemID { get; set; }
        [JsonPropertyName("qty")]
        public decimal ICROItemQty { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICROItemStkQty { get; set; }
        [JsonPropertyName("excQty")]
        public decimal ICROItemExcQty { get; set; }
        [JsonPropertyName("unitOrgStkId")]
        public int FK_ICOrgUOMID { get; set; }
        [JsonPropertyName("orgQty")]
        public decimal ICROItemOrgQty { get; set; }
        [JsonPropertyName("remainQty")]
        public decimal ICROItemRQty { get; set; }
        [JsonPropertyName("itemShipDate")]
        public Nullable<DateTime> ICROItemShpDate { get; set; }
        [JsonPropertyName("factor")]
        public decimal ICROItemFact { get; set; }
        [JsonPropertyName("adjStkQty")]
        public decimal ICROItemAdjStkQty { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
    }
}
