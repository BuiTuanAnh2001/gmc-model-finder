using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.DTO.PP
{
    [Table("PPMESNCRs")]
    public class MESNCRItemEntity : PPMESNCRs
    {
        public List<PPMESNCRBoxs> lstPPMESNCRBoxs { get; set; } = new List<PPMESNCRBoxs>();
    }
}
