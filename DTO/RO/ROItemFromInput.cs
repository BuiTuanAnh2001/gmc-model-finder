using System;

namespace gmc_api.DTO.IC
{
    public class ROItemFromInput
    {
       // public int id { get; set; }
        public int itemId { get; set; }
        public int stockId { get; set; }
        public decimal inputStockItemQty { get; set; }
        public int unitStkId { get; set; }
        public string description { get; set; }
        public decimal fact { get; set; }
        public Nullable<DateTime> itemShpDate { get; set; }
    }
}
