using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("TXTaxCodes")]
    public class TXTaxCodes : FixFiveProps
    {
        [Key]
        public int TXTaxCodeID { get; set; }
        public string TXTaxCodeNo { get; set; }
        public string TXTaxCodeName { get; set; }
        public string TXTaxCodeDesc { get; set; }
        public decimal TXTaxCodePct { get; set; }
        public int FK_GLAccountID { get; set; }
        public string TXTaxCodeTypeCombo { get; set; }
        public Boolean AASelected { get; set; }
        public string AAOrgDocNo { get; set; }
        public int FK_GLNationID { get; set; }
        public Boolean TXTaxCodeTaxableObjectCheck { get; set; }

    }
}
