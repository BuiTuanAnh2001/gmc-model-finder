using gmc_api.Base.dto;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("HRSectionNoxiouCfs")]
    public class HRSectionNoxiouCfs : FixFiveProps
    {
        [Key]
        public int HRSectionNoxiouCfID { get; set; }
        public int HRSectionNoxiouCfDesc { get; set; }
        public Boolean AAselected { get; set; }
        public int HRSectionNoxiouCfNumberDay { get; set; }
        public int FK_HRSectionID { get; set; }
        public int FK_HREmployeeLeaveConfigID { get; set; }
    }
}
