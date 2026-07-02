using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class InventoryForShipmentSearch
    {
        public DateTime searchDate { get; set; }
        public int shipmentId { get; set; }
        public List<InventoryForShipmentItemSearch> items { get; set; }
    }
}
