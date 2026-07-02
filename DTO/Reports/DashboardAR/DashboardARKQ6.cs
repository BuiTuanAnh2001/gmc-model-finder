using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardAR
{
    public class DashboardARKQ6
    {
        public string ObjectNo { get; set; }
        public string ObjectName { get; set; }
        public int OverDueDay { get; set; }
        public double Amt { get; set; }
        public double EBAmt { get; set; }
    }
}
