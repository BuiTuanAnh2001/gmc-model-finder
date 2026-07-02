using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardGL
{
    public class DashboardGLKQ6
    {
        public decimal CurrentLiabilitesAmt { get; set; }
        public decimal NonCurrentAmt { get; set; }
        public decimal EquityAmt { get; set; }
        public decimal ProvAccrualsAmt { get; set; }
        public decimal RelatedPatyPyblAmt { get; set; }
        public decimal TradePayablesAmt { get; set; }
        public decimal LiabilitiesEquity { get; set; }

    }
}
