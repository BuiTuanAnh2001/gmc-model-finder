using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class InvDateQtyByProductStockAndStockLotNo
    {
        public decimal Qty { get; set; }
        public decimal Cost { get; set; }
        public Nullable<DateTime> InvDate { get; set; }
    }
}
