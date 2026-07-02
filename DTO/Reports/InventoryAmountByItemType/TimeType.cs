using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemType
{
    public class TimeType
    {
        [JsonPropertyName("icProductTypeNo")]
        public string ICProductGroupNo { get; set; }
        [JsonPropertyName("icProductTypeName")]
        public string ICProductTypeName { get; set; }
        [JsonPropertyName("invType")]
        public string InvType { get; set; }
        [JsonPropertyName("invAmt")]
        public decimal InvAmt { get; set; }
        public decimal StkQty { get; set; }
    }
}
