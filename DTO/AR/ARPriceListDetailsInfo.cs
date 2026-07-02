using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARPriceListDetailsInfo
    {
        public int ARPriceListDetailID { get; set; }
        public int FK_ICProductID { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public int FK_PPNormID { get; set; }
        public string PPNormNo { get; set; }
        public string PPNormName { get; set; }
        public int FK_ICUOMID { get; set; }
        public string ICUOMNo { get; set; }
        public string ICUOMName { get; set; }
        public Nullable<DateTime> ARPriceListDetailFromDate { get; set; }
        public Nullable<DateTime> ARPriceListDetailToDate { get; set; }
        public decimal ARPriceListDetailFromQuantity { get; set; }
        public decimal ARPriceListDetailToQuantity { get; set; }
        public decimal ARPriceListDetailOrgPrice { get; set; }
        public decimal ARPriceListDetailProductSalePrice { get; set; }
        public int FK_GECurrencyID { get; set; }
        public string GECurrencyNo { get; set; }
        public string GECurrencyName { get; set; }
    }
}
