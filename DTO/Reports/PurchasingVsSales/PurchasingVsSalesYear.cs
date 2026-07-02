using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.PurchasingVsSales
{
    public class PurchasingVsSalesYear
    {
        public int DataMonth { get; set; }
        public int DataYear { get; set; }
        public decimal DataAmtTot { get; set; }
        public string DataType { get; set; }
    }
}
