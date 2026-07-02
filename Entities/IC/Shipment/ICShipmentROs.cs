using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICShipmentROs")]
    public class ICShipmentROs : FixFiveProps
    {
        [Key]
        public int ICShipmentROID { get; set; }
        public int FK_ICShipmentID { get; set; }
        public int FK_ICROID { get; set; }

    }
}
