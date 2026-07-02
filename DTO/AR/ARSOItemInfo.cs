using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARSOItemInfo
    {
        [JsonPropertyName("no")]
        public string ICProductNo { get; set; }
        [JsonPropertyName("name")]
        public string ICProductName { get; set; }
        [JsonPropertyName("itemQty")]
        public decimal ARSOItemQty { get; set; }
        [JsonPropertyName("units")]
        public string ICUOMName { get; set; }
        [JsonPropertyName("unitPriceF")]
        public decimal ARSOItemFUnitPrice { get; set; }
        [JsonPropertyName("priceF")]
        public decimal ARSOItemFPrice { get; set; }
        [JsonPropertyName("taxPriceF")]
        public decimal ARSOItemFTxAmt { get; set; }
        [JsonPropertyName("summaryF")]
        public decimal ARSOItemFAmtTot { get; set; }
        [JsonPropertyName("unitPrice")]
        public decimal ARSOItemUnitPrice { get; set; }
        [JsonPropertyName("price")]
        public decimal ARSOItemPrice { get; set; }
        [JsonPropertyName("taxPrice")]
        public decimal ARSOItemTxAmt { get; set; }
        [JsonPropertyName("summary")]
        public decimal ARSOItemAmtTot { get; set; }
        [JsonPropertyName("deliveryDate")]
        public Nullable<DateTime> ARSOItemShpDate { get; set; }
        public string taxNo { get; set; }
        public string taxName { get; set; }
        public decimal taxAmt { get; set; }
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
