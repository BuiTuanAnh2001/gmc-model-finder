using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.PurchasingVsSales
{
    public class PurchasingVsSalesData
    {
        public List<PurchasingVsSalesYear> year { get; set; }
        public List<PurchasingVsSalesMonth> month { get; set; }
        public List<PurchasingVsSalesSum> sum { get; set; }
    }
}
