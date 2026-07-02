using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICTransferROs")]
    public class ICTransferROs : FixFiveProps
    {
        [Key]
        public int ICTransferROID { get; set; }
        public int FK_ICTransferID { get; set; }
        public int FK_ICROID { get; set; }
    }
}
