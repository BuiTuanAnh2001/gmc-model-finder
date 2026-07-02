using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.DTO.Inventoty
{
    public class InventoryStockUOMLotNoSlotSerialNo
    {
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_ICUOMID { get; set; }
        public string ICProductNo { get; set; }
        public string ICStockNo { get; set; }
        public string ICProductDesc { get; set; }
        public int FK_ICStkUOMID { get; set; }
        public string ICStkUOMName { get; set; }
        public string ICUOMName { get; set; }
        public string ICStkUOMNo { get; set; }
        public string ICUOMNo { get; set; }
        public string ICAccountSetNo { get; set; }
        public decimal ViewInventoryStatisticBeforeQty { get; set; }
        public decimal ViewInventoryStatisticBeforeStkQty { get; set; }
        public decimal ViewInventoryStatisticBeforeCost { get; set; }
        public decimal ViewInventoryStatisticInQty { get; set; }
        public decimal ViewInventoryStatisticInStkQty { get; set; }
        public decimal ViewInventoryStatisticInCost { get; set; }
        public decimal ViewInventoryStatisticOutQty { get; set; }
        public decimal ViewInventoryStatisticOutStkQty { get; set; }
        public decimal ViewInventoryStatisticOutCost { get; set; }
        public decimal ViewInventoryStatisticAfterQty { get; set; }
        public decimal ViewInventoryStatisticAfterStkQty { get; set; }
        public decimal ViewInventoryStatisticAfterCost { get; set; }
        public decimal ViewInventoryStatisticAdjInvIncQty { get; set; }
        public decimal ViewInventoryStatisticAdjInvIncStkQty { get; set; }
        public decimal ViewInventoryStatisticAdjInvIncCost { get; set; }
        public decimal ViewInventoryStatisticAdjInvDecQty { get; set; }
        public decimal ViewInventoryStatisticAdjInvDecStkQty { get; set; }
        public decimal ViewInventoryStatisticAdjInvDecCost { get; set; }
        public int FK_GLInventoryAccountID { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public string ICProductName { get; set; }
        public string ICProductGroupNo { get; set; }
        public string ICProductGroupName { get; set; }
        public string ICStockName { get; set; }
        public decimal ViewInventoryStatisticBeforeUnitCost { get; set; }
        public decimal ViewInventoryStatisticInUnitCost { get; set; }
        public decimal ViewInventoryStatisticOutUnitCost { get; set; }
        public decimal ViewInventoryStatisticAfterUnitCost { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public string ICStockSlotNo { get; set; }
        public string ICStockSlotName { get; set; }
        public string ViewInventoryStatisticLotNo { get; set; }
        public string ViewInventoryStatisticSerialNo { get; set; }
        public string GLTOF01Combo { get; set; }
        public string GLTOF02Combo { get; set; }
        public string GLTOF03Combo { get; set; }
        public string GLTOF04Combo { get; set; }
        public string GLTOF05Combo { get; set; }
        public string GLTOF06Combo { get; set; }
        public string GLTOF07Combo { get; set; }
        public string GLTOF08Combo { get; set; }
        public string GLTOF09Combo { get; set; }
        public string GLTOF10Combo { get; set; }
        public string GLTOF11Combo { get; set; }
        public string GLTOF12Combo { get; set; }
        public string GLTOF13Combo { get; set; }
        public string GLTOF14Combo { get; set; }
        public string GLTOF15Combo { get; set; }



    }
}
