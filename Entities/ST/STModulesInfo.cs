using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.ST
{
    [Table("STModules")]
    public class STModulesInfo
    {
        [Key]
        public int STModuleID { get; set; }
        public string STModuleName { get; set; } = String.Empty;
        public string STModuleCode { get; set; } = String.Empty;
        public int STModuleMain { get; set; }
        public string STModuleType { get; set; } = String.Empty;
        public string STModuleDesc { get; set; } = String.Empty;

    }
}
