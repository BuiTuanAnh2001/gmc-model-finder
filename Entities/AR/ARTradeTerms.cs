using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("ARTradeTerms")]
    public class ARTradeTerms : FixFiveProps
    {
        [Key]
        public int ARTradeTermID { get; set; }
        public Boolean AASelected { get; set; }
        public string ARTradeTermNo { get; set; }
        public string ARTradeTermName { get; set; }
        public string ARTradeTermDesc { get; set; }
        public string ARTradeTermDateCalcTypeCombo { get; set; }
        public string ARTradeTermMaturityTypeCombo { get; set; }
        public int ARTradeTermDay { get; set; }

    }
}
