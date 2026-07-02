using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardAP
{
    public class DashboardAPReportData
    {
        public List<DashboardAPKQ1> DashboardARKQ1 { get; set; }
        public List<DashboardAPKQ2> DashboardARKQ2 { get; set; }
        public List<DashboardAPKQ3> DashboardARKQ3 { get; set; }
        public List<DashboardAPKQ4> DashboardARKQ4 { get; set; }
        public List<DashboardAPKQ5> DashboardARKQ5 { get; set; }

    }
}
