using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICShipmentPurchaseReturns")]
    public class ICShipmentPurchaseReturnsInfo
	{
        [Key]
		public int ICShipmentPurchaseReturnID { get; set; }
		public String AAStatus { get; set; } = "Alive";
		public int FK_ICShipmentID { get; set; }
		public int FK_APPurchaseReturnID { get; set; }

	}
}
