using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemIcode
{
    public class TimeTypeICode
    {
        [JsonPropertyName("adOFItemNo")]
        public string ADOFItemNo { get; set; }
        [JsonPropertyName("icProductTypeName")]
        public string ICProductTypeName { get; set; }
        [JsonPropertyName("invType")]
        public string InvType { get; set; }
        [JsonPropertyName("invAmt")]
        public decimal InvAmt { get; set; }
    }
}
