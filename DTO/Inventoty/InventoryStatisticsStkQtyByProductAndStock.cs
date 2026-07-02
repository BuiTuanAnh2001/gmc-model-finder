using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class InventoryStatisticsStkQtyByProductAndStock
    {
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICProductNo { get; set; }
        public string ICStockNo { get; set; }
        public int FK_ICUOMID { get; set; }
        public decimal ViewInventoryStatisticBeforeQty { get; set; }
        public decimal ViewInventoryStatisticBeforeCost { get; set; }
        public decimal ViewInventoryStatisticInQty { get; set; }
        public decimal ViewInventoryStatisticInCost { get; set; }
        public decimal ViewInventoryStatisticOutQty { get; set; }
        public decimal ViewInventoryStatisticOutCost { get; set; }
        public decimal ViewInventoryStatisticAfterQty { get; set; }
        public decimal ViewInventoryStatisticAfterCost { get; set; }
        public decimal ViewInventoryStatisticAdjInvIncQty { get; set; }
        public decimal ViewInventoryStatisticAdjInvIncCost { get; set; }
        public decimal ViewInventoryStatisticAdjInvDecQty { get; set; }
        public decimal ViewInventoryStatisticAdjInvDecCost { get; set; }
        public int FK_GLInventoryAccountID { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public string ICProductName { get; set; }
      //  public int FK_GLInventoryAccountID { get; set; }
        public string ICProductGroupName { get; set; }
        public string ICStockName { get; set; }
        public decimal ViewInventoryStatisticBeforeUnitCost { get; set; }
        public decimal ViewInventoryStatisticInUnitCost { get; set; }
        public decimal ViewInventoryStatisticOutUnitCost { get; set; }
        public decimal ViewInventoryStatisticAfterUnitCost { get; set; }

    }
}
