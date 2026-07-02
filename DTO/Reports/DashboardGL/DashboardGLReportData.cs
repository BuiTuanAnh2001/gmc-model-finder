using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardGL
{
    public class DashboardGLReportData
    {
        public List<DashboardGLKQ1> DashboardGLKQ1 { get; set; }
        public List<DashboardGLKQ2> DashboardGLKQ2 { get; set; }
        public List<DashboardGLKQ3> DashboardGLKQ3 { get; set; }
        public List<DashboardGLKQ4> DashboardGLKQ4 { get; set; }
        public List<DashboardGLKQ5> DashboardGLKQ5 { get; set; }
        public List<DashboardGLKQ6> DashboardGLKQ6 { get; set; }
    }
}
