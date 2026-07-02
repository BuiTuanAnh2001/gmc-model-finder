using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DownTime
{
    public class DownTimeSum
    {
        public decimal ActQty { get; set; }
        public decimal PlanQty { get; set; }
        public decimal DowntimeQty { get; set; }
        public decimal DowntimePct { get; set; }

    }
}
