using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DownTime
{
    public class DownTimeResource
    {
        public string Argument { get; set; }
        public decimal DowntimePct { get; set; }

    }
}
