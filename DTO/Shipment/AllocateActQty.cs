using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class AllocateActQty : ICShipmentProductTotals
    {
        public List<ICShipmentProductAllocates> prodAllocates { get; set; } = new List<ICShipmentProductAllocates>();
    }
}
