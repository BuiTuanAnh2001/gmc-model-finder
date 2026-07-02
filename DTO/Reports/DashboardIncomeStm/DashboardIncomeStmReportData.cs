using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardIncomeStm
{
    public class DashboardIncomeStmReportData
    {
        public List<DashboardIncomeStmKQ1> DashboardIncomeStmKQ1 { get; set; }
        public List<DashboardIncomeStmKQ2> DashboardIncomeStmKQ2 { get; set; }
        public List<DashboardIncomeStmKQ3> DashboardIncomeStmKQ3 { get; set; }
        public List<DashboardIncomeStmKQ4> DashboardIncomeStmKQ4 { get; set; }
        public List<DashboardIncomeStmKQ5> DashboardIncomeStmKQ5 { get; set; }
    }
}
