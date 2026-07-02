using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("PPToolManagements")]
    public class PPToolManagements : FixFiveProps
    {
        [Key]
        public int PPToolManagementID { get; set; }
        public int FK_ICProductID { get; set; }
        public int FK_PPResourceID { get; set; }
        public bool AASelected { get; set; }
        public bool PPToolManagementUseCheck { get; set; }
        public String PPToolManagementNo { get; set; }
        public String PPToolManagementName { get; set; }
        public Nullable<DateTime> PPToolManagementDate { get; set; }
        public String PPToolManagementDesc { get; set; }
    }
}
