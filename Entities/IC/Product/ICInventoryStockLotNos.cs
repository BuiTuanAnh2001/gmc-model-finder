using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICInventoryStockLotNos")]
    public class ICInventoryStockLotNos
    {
        [Key]
        public int ICInventoryStockLotNoID { get; set; }
        public string AAStatus { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICInventoryStockLotNoProductLotNo { get; set; } = string.Empty;
        public string ICInventoryStockLotNoPOF01Combo { get; set; } = string.Empty;
        public string ICInventoryStockLotNoPOF02Combo { get; set; } = string.Empty;
        public string ICInventoryStockLotNoPOF03Combo { get; set; } = string.Empty;
        public string ICInventoryStockLotNoPOF04Combo { get; set; } = string.Empty;
        public string ICInventoryStockLotNoPOF05Combo { get; set; } = string.Empty;
        public string ICInventoryStockLotNoProductSerialNo { get; set; } = string.Empty;
        public decimal ICInventoryStockLotNoQuantity { get; set; }
        public decimal ICInventoryStockLotNoStkQuantity { get; set; }
        public decimal ICInventoryStockLotNoProposalQuantity { get; set; }
        public decimal ICInventoryStockLotNoSaleOrderQuantity { get; set; }
        public decimal ICInventoryStockLotNoPurchaseOrderQuantity { get; set; }
        public Nullable<DateTime> ICInventoryStockLotNoExpireDate { get; set; }
        public int FK_ICStockSlotID { get; set; }
        public int FK_ICUOMID { get; set; }
        public decimal ICInventoryStockLotNoFact { get; set; }
        public decimal ICInventoryStockLotNoBalanceQty { get; set; }
        public decimal ICInventoryStockLotNoAllocateQty { get; set; }

    }
}
