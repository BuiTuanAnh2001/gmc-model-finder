using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemIcode
{
    public class MonthTotalICode
    {
        [JsonPropertyName("invAmt")]
        public decimal InvAmt { get; set; }
        [JsonPropertyName("invDate")]
        public Nullable<DateTime> InvDate { get; set; }
    }
}
