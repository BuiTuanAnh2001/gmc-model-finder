using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("GLTranCfgs")]
    public class GLTranCfgs : FixFiveProps
    {
        [Key]
        public int GLTranCfgID { get; set; }
        public string GLTranCfgNo { get; set; }
        public string GLTranCfgName { get; set; }
        public string GLTranCfgDesc { get; set; }
        public string GLTranCfgCode { get; set; }
        public int FK_GLDebitAccountID { get; set; }
        public int FK_GLCreditAccountID { get; set; }
        public int FK_GLDebitVATAccountID { get; set; }
        public int FK_GLCreditVATAccountID { get; set; }
        public string GLTranCfgGroup { get; set; }
        public string GLTranCfgObjectTypeCombo { get; set; }
        public string TXTaxCodeTypeCombo { get; set; }
        public int FK_TXTaxCodeID { get; set; }
        public Boolean AASelected { get; set; }
        public string AAOrgDocNo { get; set; }
        public int FK_GLTranCfgGroupID { get; set; }
        public Nullable<DateTime> GLTranCfgApplyFromDate { get; set; }
        public Nullable<DateTime> GLTranCfgApplyToDate { get; set; }
        public Boolean GLTranCfgActiveCheck { get; set; }
        public Boolean GLTranCfgNoEditCheck { get; set; }
        public Boolean GLTranCfgLockAfterSaveCheck { get; set; }
        public int FK_GENumberingID { get; set; }
        public Boolean GLTranCfgStkUnitPriceCheck { get; set; }
        public Boolean GLTranCfgBaseCurrencyCheck { get; set; }
    }
}
