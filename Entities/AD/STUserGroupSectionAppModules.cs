using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("STUserGroupSectionAppModules")]
    public class STUserGroupSectionAppModules
    {
        [Key]
        public int STUserGroupSectionAppModuleID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public string STUserGroupSectionAppModuleCode { get; set; }
        public string STUserGroupSectionAppModuleName { get; set; }
        public int FK_ADUserGroupID { get; set; }
        public int STUserGroupSectionAppModuleSortOrder { get; set; }
    }
}
