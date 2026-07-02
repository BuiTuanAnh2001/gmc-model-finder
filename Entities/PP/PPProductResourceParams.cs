using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPProductResourceParams")]
    public class PPProductResourceParams : FixFiveProps
    {
        [Key]

        public int PPProductResourceParamID { get; set; }
        public int FK_PPResourceParamID { get; set; }
        public int FK_PPResourceID { get; set; }
        public int FK_ICProductGroupID { get; set; }
        public int FK_ICProductID { get; set; }
        public String PPProductResourceParamValue { get; set; }
        public bool AASelected { get; set; }
        public bool PPProductResourceParamCheck { get; set; }
        public decimal PPProductResourceParamMinValue { get; set; }
        public decimal PPProductResourceParamMaxValue { get; set; }
    }
}
