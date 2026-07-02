using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardAR
{
    public class DashboardARKQ5
    {
        public string ObjectNo { get; set; }
        public double RAmt { get; set; }
        public double OverRAmt { get; set; }
    }
}
