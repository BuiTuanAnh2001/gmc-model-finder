using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardGL
{
    public class DashboardGLKQ2
    {
        public string Argument { get; set; }
        public decimal RevAmt { get; set; }
        public decimal COGSAmt { get; set; }
        public decimal ProfitAmt { get; set; }
        public decimal CPAmt { get; set; }
        public decimal NetProfitAmt { get; set; }
        public decimal ProfitPct { get; set; }
        public decimal NetProfitPct { get; set; }
        public decimal ProfitPctAmt { get; set; }

    }
}
