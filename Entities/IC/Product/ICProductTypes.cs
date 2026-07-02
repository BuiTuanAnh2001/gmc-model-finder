using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ICProductTypes")]
    public class ICProductTypes : FixFiveProps
    {
        [Key]
        public int ICProductTypeID { get; set; }
        public string ICProductTypeNo { get; set; }
        public string ICProductTypeName { get; set; }
        public string ICProductTypeDesc { get; set; }

    }
}
