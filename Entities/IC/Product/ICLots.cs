using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ICLots")]
    public class ICLots : FixFiveProps
    {
        [Key]
        public int ICLotID { get; set; }
        public string ICLotNo { get; set; }
        public string ICLotName { get; set; }
        public string ICLotDesc { get; set; }
        public string ICLotTrackingMethodCombo { get; set; }
        public Boolean ICLotIsTrackExpireDate { get; set; }
        public string ICLotAssignmentMethodCombo { get; set; }
        public string ICLotIssueMethodCombo { get; set; }
        public string ICLotTrackWhenCombo { get; set; }

    }
}
