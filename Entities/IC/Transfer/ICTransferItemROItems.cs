using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICTransferItemROItems")]
    public class ICTransferItemROItems : FixFiveProps
    {
        [Key]
        public int ICTransferItemROItemID { get; set; }
        public int FK_ICTransferItemID { get; set; }
        public int FK_ICROItemID { get; set; }

    }
}
