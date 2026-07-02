using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShipmentItemFromInput
    {
        //RO OR PRODUCT RST ID//
        public int id { get; set; }
        //RO ITEMS OR PRODUCT RST ITEMS ID//
        public int itemId { get; set; }
        public int productId { get; set; }
        public decimal inputStockItemQty { get; set; }
        public int unitId {  get; set; }
        public int stockId { get; set; }
        public decimal stkQty { get; set; }
        public int unitStkId {  get; set; }
        public decimal fact { get; set; }
        public int stockSlotId { get; set; }
        public string lotNo { get; set; }
        public string description { get; set; }
        public int costCenter { get; set; }


    }
}
