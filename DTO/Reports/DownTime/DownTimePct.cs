using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DownTime
{
    public class DownTimePct
    {
        public int Argument { get; set; }
        public string ArgumentName { get; set; }
        public decimal DowntimePct { get; set; }

    }
}
