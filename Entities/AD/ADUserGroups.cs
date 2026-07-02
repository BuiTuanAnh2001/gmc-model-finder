using gmc_api.Base.dto;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace gmc_api.Entities
{
    [Table("ADUserGroups")]
    public class ADUserGroups
    {
        [Key]
        public int ADUserGroupID { get; set; }
        public string AAStatus { get; set; } = "Alive";
        public int ADLanguageIDCombo { get; set; }
        public string ADCommentRefID { get; set; } = string.Empty;
        public string ADUserGroupSkinCombo { get; set; } = string.Empty;
        public string ADUserGroupName { get; set; } = string.Empty;
        public string ADUserGroupDesc { get; set; } = string.Empty;
    }
}
