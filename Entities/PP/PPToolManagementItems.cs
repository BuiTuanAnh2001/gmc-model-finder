using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPToolManagementItems")]
    public class PPToolManagementItems : FixFiveProps
    {
        [Key]
        public int PPToolManagementItemID { get; set; }
        public int FK_PPProductionOrdrEstFGID { get; set; }
        public int FK_ICToolProductID { get; set; }
        public string PPToolManagementItemStatus { get; set; }
        public bool AASelected { get; set; }
        public int FK_PPToolManagementItemID { get; set; }
        public int FK_PPProductionOrdrID { get; set;}
        public int PPToolManagementItemUseStatus { get; set; }
    }
}
