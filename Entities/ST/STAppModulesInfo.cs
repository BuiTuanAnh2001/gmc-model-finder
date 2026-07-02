using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace gmc_api.Entities.ST
{
    [Table("STAppModules")]
    public class STAppModulesInfo
    {
        [Key]
        public int STAppModuleID { get; set; }
        public string STAppModuleName { get; set; } = String.Empty;
        public string STAppModuleCode { get; set; } = String.Empty;
        public int STAppModuleMain {  get; set; }   
        public string STAppModuleType { get; set; } = String.Empty;
        public string STAppModuleDesc { get; set; } = String.Empty;
        public string STAppModuleBIUrl { get; set; } = String.Empty;
    }
}
