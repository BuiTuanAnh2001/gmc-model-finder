using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("APPRPOs")]
    public class APPRPOsInfo
    {
        [Key]
		public int APPRPOID { get; set; }
		public String AAStatus { get; set; } = "Alive";
		public int FK_APPOID { get; set; }
		public int FK_APPRID { get; set; }

	}
}
