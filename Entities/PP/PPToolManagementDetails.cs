using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPToolManagementDetails")]
    public class PPToolManagementDetails 
    {
        [Key]
        public int PPToolManagementDetailID { get; set; }
        public int FK_PPToolManagementID { get; set; }
        public int FK_ICToolProductID { get; set; }
    }
}
