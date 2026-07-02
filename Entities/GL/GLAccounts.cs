using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("GLAccounts")]
    public class GLAccounts : FixFiveProps
    {
        [Key]
        public int GLAccountID { get; set; }
        public Boolean AASelected { get; set; }
        public int FK_GLAccountParentID { get; set; }
        public string GLAccountNo { get; set; }
        public string GLAccountDesc { get; set; }
        public Boolean GLAccountActiveCheck { get; set; }
        public string GLAccountTypeCombo { get; set; }
        public string GLAccountBalanceCombo { get; set; }
        public int FK_GLAccountGroupID { get; set; }
        public string GLAccountName { get; set; }
        public int GLAccountLevel { get; set; }
        public string GLAccountFName { get; set; }
        public string GLAccountAOF01Combo { get; set; }
        public string GLAccountAOF02Combo { get; set; }
        public string GLAccountAOF03Combo { get; set; }
        public string GLAccountAOF04Combo { get; set; }
        public string GLAccountAOF05Combo { get; set; }
        public string GLAccountAOF06Combo { get; set; }
        public string GLAccountAOF07Combo { get; set; }
        public string GLAccountAOF08Combo { get; set; }
        public string GLAccountAOF09Combo { get; set; }
        public string GLAccountAOF10Combo { get; set; }
        public string GLAccountAOF11Combo { get; set; }
        public string GLAccountAOF12Combo { get; set; }
        public string GLAccountAOF13Combo { get; set; }
        public string GLAccountAOF14Combo { get; set; }
        public string GLAccountAOF15Combo { get; set; }

    }
}
