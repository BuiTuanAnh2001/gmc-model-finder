using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardAR
{
    public class DashboardARReportData
    {
        public List<DashboardARKQ1> DashboardARKQ1 { get; set; }
        public List<DashboardARKQ2> DashboardARKQ2 { get; set; }
        public List<DashboardARKQ3> DashboardARKQ3 { get; set; }
        public List<DashboardARKQ4> DashboardARKQ4 { get; set; }
        public List<DashboardARKQ5> DashboardARKQ5 { get; set; }
        public List<DashboardARKQ6> DashboardARKQ6 { get; set; }
    }
}
