using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICBarCodeSetups")]
    public class ICBarCodeSetups : FixFiveProps
    {
        [Key]
        public int ICBarCodeSetupID { get; set; }
        public string ICBarCodeSetupNo { get; set; }
        public Nullable<DateTime> ICBarCodeSetupDate { get; set; }
        public string ICBarCodeSetupName { get; set; }
        public string ICBarCodeSetupDesc { get; set; }
        public string ICBarCodeSetupSeperatorCombo { get; set; }

    }
}
