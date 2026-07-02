using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.DashboardGL
{
    public class DashboardGLKQ5
    {
        public decimal CurrentAssetsAmt { get; set; }
        public decimal FixedAssetsAmt { get; set; }
        public decimal CashBankBalAmt { get; set; }
        public decimal DepositedAdvAmt { get; set; }
        public decimal InventoryAmt { get; set; }
        public decimal TradeReceivablesAmt { get; set; }
        public decimal TotalAssets { get; set; }
    }
}
