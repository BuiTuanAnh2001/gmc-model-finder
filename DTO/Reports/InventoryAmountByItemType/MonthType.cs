using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemType
{
    public class MonthType
    {
        [JsonPropertyName("icProductTypeNo")]
        public string ICProductGroupNo { get; set; }
        [JsonPropertyName("icProductTypeName")]
        public string ICProductTypeName { get; set; }
        [JsonPropertyName("invAmt")]
        public decimal InvAmt { get; set; }
        [JsonPropertyName("invDate")]
        public Nullable<DateTime> InvDate { get; set; }
        public decimal StkQty { get; set; }
    }
}
