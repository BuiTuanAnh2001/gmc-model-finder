using gmc_api.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.DTO.PP
{
    [Table("PPMESPallets")]
    public class MESPalletItemEntity : PPMESPallets
    {
        public List<PPMESPalletBoxs> lstPPMESPalletBoxs { get; set; } = new List<PPMESPalletBoxs>();
    }
}
