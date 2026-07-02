using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("GECurrencys")]
    public class GECurrencys
    {
        [Key]
        public int GECurrencyID { get; set; }
        public string AAStatus { get; set; }
        public string GECurrencyNo { get; set; }
        public string GECurrencyName { get; set; }
        public string GECurrencyDesc { get; set; }
        public decimal GECurrencyExRate { get; set; }
        public decimal GECurrencyValue { get; set; }
        public int GECurrencyDecimalRound { get; set; }
        public Boolean AASelected { get; set; }
        public string AAOrgDocNo { get; set; }
        public string GECurrencyOperatorCombo { get; set; }
        public decimal GECurrencyAdjRange { get; set; }
        public int GECurrencyPriceDecimalRound { get; set; }
        public string GECurrencyExcRateMethodCombo { get; set; }
        public string GECurrencyUnitName { get; set; }
    }
}
