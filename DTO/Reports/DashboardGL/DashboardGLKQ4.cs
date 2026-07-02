using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardGL
{
    public class DashboardGLKQ4
    {
        public string Argument { get; set; }
        public decimal GLJournalAmt { get; set; }
    }
}
