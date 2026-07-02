using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class APPOItemInfo
    {
        [JsonPropertyName("no")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("name")]
        public string ICProductName { get; set; }
        [JsonPropertyName("itemQty")]
        public decimal APPOItemQty { get; set; }
        [JsonPropertyName("units")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("stkQty")]
        public decimal APPOItemStkQty { get; set; }
        [JsonPropertyName("unitPrice")]
        public decimal APPOItemUnitPrice { get; set; }
        [JsonPropertyName("summary")]
        public decimal APPOItemAmtTot { get; set; }
        [JsonPropertyName("unitStk")]
        public string ICUOMNameStk { get; set; }
        [JsonPropertyName("arrivalDate")]
        public Nullable<DateTime> APPOItemArrivalDate { get; set; }
        [JsonPropertyName("unitFPrice")]
        public decimal APPOItemFUnitPrice { get; set; }
        [JsonPropertyName("price")]
        public decimal APPOItemPrice { get; set; }
        [JsonPropertyName("fPrice")]
        public decimal APPOItemFPrice { get; set; }
        [JsonPropertyName("fSummary")]
        public decimal APPOItemFAmtTot { get; set; }
        [JsonPropertyName("description")]
        public string APPOItemDesc { get; set; }
        public string taxNo { get; set; }
        public string taxName { get; set; }
        public decimal taxAmt { get; set; }
        public decimal APPOItemFTxAmt { get; set; }
        [JsonPropertyName("comment")]
        public string APPOItemComment { get; set; }
        public decimal APPOItemMRPQty { get; set; }
        public decimal APPOItemApprovedMRPQty { get; set; }
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
