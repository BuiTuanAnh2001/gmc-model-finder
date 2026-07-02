using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPRItemPOItems")]
    public class APPRItemPOItemsInfo
	{
        [Key]
		public int APPRItemPOItemID { get; set; }
		public String AAStatus { get; set; } = "Alive";
		public int FK_APPRItemID { get; set; }
		public int FK_APPOItemID { get; set; }

	}
}
