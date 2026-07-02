using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.GE
{
    [Table("GEUserAudits")]
    public class GEUserAuditsInfo
    {
        [Key]
        public int GEUserAuditID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public int ADUserID { get; set; }
        public string ADUserName { get; set; } = String.Empty;
        public string GEUserAuditModuleName { get; set; } = String.Empty;
        public Nullable<DateTime> GEUserAuditBeginDate { get; set; } 
        public string GEUserAuditAction { get; set; } = String.Empty;
        public string GEUserAuditParameter { get; set; } = String.Empty;
        public string GEUserAuditPCName { get; set; } = String.Empty;
        public string GEUserAuditIP { get; set; } = String.Empty;
    }
}
