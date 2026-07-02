using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemIcode
{
    public class ProTypeICode
    {
        [JsonPropertyName("icProductTypeNo")]
        public string ICProductTypeNo { get; set; }
        [JsonPropertyName("icProductTypeName")]
        public string ICProductTypeName { get; set; }
        [JsonPropertyName("invAmt")]
        public decimal InvAmt { get; set; }
    }
}
