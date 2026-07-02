namespace gmc_api.DTO.AR
{
    public class OtherSO
    {
        public string ARCustomerNo { get; set; }
        public string ARCustomerName { get; set; }
        public decimal ARSOCusActualBalance { get; set; }
        public decimal ARSOCusApprovalSORAmt { get; set; }
        public decimal ARSOItmPriceTot { get; set; }
        public decimal ARSOTxAmtTot { get; set; }
        public decimal ARSOAmtTot { get; set; }
        public decimal ARSOCusOverCrdLimit { get; set; }
        public decimal ARSOEstOverCrdLimit { get; set; }
        public decimal ARSOOverLimitPct { get; set; }
        public int ARSODueDay { get; set; }

    }
}
