using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PR
{
    public class APPRItemInfo
    {
        [JsonPropertyName("no")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("name")]
        public string ICProductName { get; set; }
        [JsonPropertyName("itemQty")]
        public decimal APPRItemQty { get; set; }
        [JsonPropertyName("units")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal APPRItemStkQty { get; set; }
        [JsonPropertyName("unitStk")]
        public string ICUOMNameStk { get; set; }
        [JsonPropertyName("arrivalDate")]
        public Nullable<DateTime> APPRItemArrivalDate { get; set; }
        public decimal APPRItemFUnitPrice { get; set; }
        public decimal APPRItemUnitPrice { get; set; }
        public decimal APPRItemFAmtTot { get; set; }
        public decimal APPRItemAmtTot { get; set; }
        public decimal APPRItemPrice { get; set; }
        [JsonPropertyName("prItemDesc")]
        public string APPRItemDesc { get; set; }
        public string taxNo { get; set; }
        public string taxName { get; set; }
        public decimal taxAmt { get; set; }
        public decimal APPRItemFTxAmt { get; set; }
        public string GLTOF01Combo { get; set; }
        public string GLTOF02Combo { get; set; }
        public string GLTOF03Combo { get; set; }
        public string GLTOF04Combo { get; set; }
        public string GLTOF05Combo { get; set; }
        public string GLTOF06Combo { get; set; }
        public string GLTOF07Combo { get; set; }
        public string GLTOF08Combo { get; set; }
        public string GLTOF09Combo { get; set; }
        public string GLTOF10Combo { get; set; }
        public string GLTOF11Combo { get; set; }
        public string GLTOF12Combo { get; set; }
        public string GLTOF13Combo { get; set; }
        public string GLTOF14Combo { get; set; }
        public string GLTOF15Combo { get; set; }
    }
}
