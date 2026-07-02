using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ARAdjPriceListCfgs")]
    public class ARAdjPriceListCfgs
    {
        [Key]
        public int ARAdjPriceListCfgID { get; set; }
        public Nullable<DateTime> AACreatedDate { get; set; }
        public string AACreatedUser { get; set; }
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public string AAUpdatedUser { get; set; }
        public string AAStatus { get; set; }
        public Boolean AASelected { get; set; }
        public string ARAdjPriceListCfgColumn { get; set; }
        public string ARAdjPriceListCfgTable { get; set; }
        public string ARAdjPriceListCfgDesc { get; set; }
        public string ARAdjPriceListCfgCaption { get; set; }
        public string ARAdjPriceListCfgTypeCombo { get; set; }
    }
}
