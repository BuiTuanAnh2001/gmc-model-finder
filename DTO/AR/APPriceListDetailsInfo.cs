using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class APPriceListDetailsInfo
    {
        public int APPriceListDetailID { get; set; }
        public int FK_ICProductID { get; set; }
        public string ICProductNo { get; set; }
        public string ICProductName { get; set; }
        public int FK_ICUOMID { get; set; }
        public string ICUOMNo { get; set; }
        public string ICUOMName { get; set; }
        public Nullable<DateTime> APPriceListDetailFromDate { get; set; }
        public Nullable<DateTime> APPriceListDetailToDate { get; set; }
        public decimal APPriceListDetailFromQuantity { get; set; }
        public decimal APPriceListDetailToQuantity { get; set; }
        public decimal APPriceListDetailFUnitPrice { get; set; }
        public decimal APPriceListDetailUnitPrice { get; set; }
        public int FK_GECurrencyID { get; set; }
        public string GECurrencyNo { get; set; }
        public string GECurrencyName { get; set; }
    }
}
