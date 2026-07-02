using gmc_api.Base.dto;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.AR
{
    public class ARPriceListSearch
    {
        public string DocNo { get; set; } = string.Empty;
         public string DocName { get; set; } = string.Empty;
        public DateTime FromDate { get; set; } = DateTime.Now;
        public DateTime ToDate { get; set; } = DateTime.Now;
        public int FK_ICProductID { get; set; }
    }
}
