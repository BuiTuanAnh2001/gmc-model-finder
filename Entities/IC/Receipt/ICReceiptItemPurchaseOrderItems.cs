using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICReceiptItemPurchaseOrderItems")]
    public class ICReceiptItemPurchaseOrderItems
    {
        [Key]
        public int ICReceiptItemPurchaseOrderItemID { get; set; }
        public string AAStatus { get; set; } = string.Empty;
        public int FK_APPOItemID { get; set; }
        public int FK_ICReceiptItemID { get; set; }
    }
}
