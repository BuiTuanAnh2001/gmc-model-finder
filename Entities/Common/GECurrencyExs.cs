using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("GECurrencyExs")]
    public class GECurrencyExs
    {
        [Key]
        public int GECurrencyExID { get; set; }
        public int FK_GECurrencyID { get; set; }
        public Nullable<DateTime> GECurrencyExDate { get; set; }
        public decimal GECurrencyExRate { get; set; }
        public string GECurrencyExDesc { get; set; }
        public int FK_GECurrencyExObjID { get; set; }

    }
}
