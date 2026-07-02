using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICShipmentItemROItems")]
    public class ICShipmentItemROItems : FixFiveProps
    {
        [Key]
        public int ICShipmentItemROItemID { get; set; }
        public int FK_ICShipmentItemID { get; set; }
        public int FK_ICROItemID { get; set; }
    }
}
