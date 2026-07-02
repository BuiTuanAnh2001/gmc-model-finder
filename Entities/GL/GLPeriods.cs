using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities
{
    [Table("GLPeriods")]
    public class GLPeriods 
    {
        [Key]
        public int GLPeriodID { get; set; }
        public string AACreatedUser { get; set; }
        public Nullable<DateTime> AAUpdatedDate { get; set; }
        public string AAUpdatedUser { get; set; }
        public Nullable<DateTime> AACreatedDate { get; set; }
        public int GLPeriodMonth { get; set; }
        public int GLPeriodYear { get; set; }
        public Boolean GLPeriodLock { get; set; }
        public int GLPeriodCountLock { get; set; }
        public int GLPeriodCountUnlock { get; set; }
        public string GLPeriodObjectNameUnLock { get; set; }
        public string GLPeriodObjectNameLock { get; set; }
        public int FK_GLYearID { get; set; }
        public int GLPeriodTransferCount { get; set; }
        public Boolean GLPeriodTransferStatus { get; set; }
        public int GLPeriodDayEndProcessCount { get; set; }
        public Boolean GLPeriodPECheck { get; set; }
        public Boolean GLPeriodEQCheck { get; set; }
        public Boolean GLPeriodFACheck { get; set; }
        public Boolean GLPeriodSMCheck { get; set; }
        public Boolean GLPeriodPMCheck { get; set; }
        public Boolean GLPeriodICCheck { get; set; }
        public Boolean GLPeriodCMCheck { get; set; }
        public Boolean GLPeriodARCheck { get; set; }
        public Boolean GLPeriodAPCheck { get; set; }

    }
}
