namespace gmc_api.DTO.IC
{
    public class ShipmentItemFromDirectInput
    {
        public int productId { get; set; }
        public decimal qty { get; set; }
        public int unitId { get; set; }
        public int unitStkId { get; set; }
        public decimal factor { get; set; }
        public int stockId { get; set; }
        public string lotNo { get; set; }
        public int stockSlot { get; set; }
        public string description { get; set; }
    }
}
