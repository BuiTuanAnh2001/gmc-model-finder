using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICInventoryStockSerials")]
    public class ICInventoryStockSerials
    {
        [Key]
        public int ICInventoryStockSerialID { get; set; }
        public string AAStatus { get; set; }
        public int FK_ICInventoryStockID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICInventoryStockSerialProductSerialNo { get; set; }
        public decimal ICInventoryStockSerialQuantity { get; set; }
        public decimal ICInventoryStockSerialProposalQuantity { get; set; }
        public decimal ICInventoryStockSerialSaleOrderQuantity { get; set; }
        public decimal ICInventoryStockSerialPurchaseOrderQuantity { get; set; }
        public int FK_ICUOMID { get; set; }
        public decimal ICInventoryStockSerialStkQuantity { get; set; }

    }
}
