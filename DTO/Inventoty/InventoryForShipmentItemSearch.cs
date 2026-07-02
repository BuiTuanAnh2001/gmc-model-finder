using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class InventoryForShipmentItemSearch
    {
        public int itemId { get; set; } = 0;
        public int productId { get; set; }
        public int stockId { get; set; }
        public int stockSlotId { get; set; }
        public decimal currentQty { get; set; }
        public decimal oldQty { get; set; } // =0 nếu isNew = true
        public String lotNo { get; set; }
        public int unitId { get; set; }
    }
}
