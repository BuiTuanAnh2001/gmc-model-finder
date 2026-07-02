using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.PurchasingVsSales
{
    public class PurchasingVsSalesSum
    {
        public decimal ViewReportQty { get; set; }
        public decimal ViewReportRQty { get; set; }
        public decimal ViewReportCloseQty { get; set; }
    }
}
