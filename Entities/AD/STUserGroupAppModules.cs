using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("STUserGroupAppModules")]
    public class STUserGroupAppModules
    {
        [Key]
        public int STUserGroupAppModuleID { get; set; } = 0;
        public string AAStatus { get; set; } = "Alive";
        public string STAppModuleCode { get; set; } = String.Empty;
        public string STAppModuleName { get; set; } = string.Empty;
        public int FK_ADUserGroupID { get; set; } = 0;
        public int FK_STUserGroupSectionAppModuleID { get; set; } = 0;
        public int STUserGroupAppModuleSortOrder { get; set; } = 0;
        public string STUserGroupAppModuleSetting { get; set; } = String.Empty;
    }
}
