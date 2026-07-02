using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICShipmentItemPurchaseReturnItems")]
    public class ICShipmentItemPurchaseReturnItemsInfo
	{
        [Key]
		public int ICShipmentItemPurchaseReturnItemID { get; set; }
		public String AAStatus { get; set; } = "Alive";
		public int FK_ICShipmentItemID { get; set; }
		public int FK_APPurchaseReturnItemID { get; set; }

	}
}
