using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROItemForTransfer
    {

        [JsonPropertyName("itemId")]
        public int ICROItemID { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("productName")]
        public string productName { get; set; }
        [JsonPropertyName("productNo")]
        public string productNo { get; set; }
        [JsonPropertyName("inputStockItemQty")]
        public decimal inputStockItemQty { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("unitStkId")]
        public int FK_ICStkUOMID { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICROItemStkQty { get; set; }
        [JsonPropertyName("fact")]
        public decimal ICROItemFact { get; set; }
        [JsonPropertyName("lotNo")]
        public string lotNo { get; set; } = "";
        [JsonPropertyName("barCode")]
        public string barCode { get; set; } = "";
        [JsonPropertyName("fromStkId")]
        public int FK_ICFromStockID { get; set; } = 0;
        [JsonPropertyName("toStkId")]
        public int FK_ICToStockID { get; set; } = 0;
        [JsonPropertyName("invQty")]
        public decimal invQty { get; set; } = 0;
        [JsonPropertyName("fgLotNo")]
        public string fgLotNo { get; set; }
        [JsonPropertyName("description")]
        public string description { get; set; } = "";
        [JsonPropertyName("stockId")]
        public int stockId { get; set; }
        [JsonPropertyName("stockSlotId")]
        public int stockSlotId { get; set; }
      
    }
}
