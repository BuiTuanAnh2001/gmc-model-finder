using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICStockExceptAllowNegatives")]
    public class ICStockExceptAllowNegatives : FixFiveProps
    {
        [Key]
        public int ICStockExceptAllowNegativeID { get; set; }
        public int FK_ICStockID { get; set; }
        public string ICStockExceptAllowNegativeTypeCombo { get; set; }
        public string ICStockExceptAllowNegativeLevelCombo { get; set; }

    }
}
