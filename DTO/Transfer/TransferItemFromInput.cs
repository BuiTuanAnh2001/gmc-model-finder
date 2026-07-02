using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Transfer
{
    public class TransferItemFromInput
    {
        //RO OR PRODUCT RST ID//
        public int id { get; set; }
        //RO ITEMS OR PRODUCT RST ITEMS ID//
        public int itemId { get; set; }
        public decimal inputStockItemQty { get; set; }
        public int fromSktId { get; set; }
        public int toSktId { get; set; }
        public string lotNo { get; set; }
        public string description { get; set; }
        [JsonPropertyName("fact")]
        public decimal ICTransferItemFact { get; set; }
        [JsonPropertyName("unitId")]
        public int FK_ICUOMID { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal ICTransferItemStkQty { get; set; }
        [JsonPropertyName("unitStockId")]
        public int FK_ICStkUOMID { get; set; }
    }
}
