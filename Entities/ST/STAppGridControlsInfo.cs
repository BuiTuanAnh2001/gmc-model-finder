using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.Entities.ST
{
    [Table("STAppGridControls")]
    public class STAppGridControlsInfo
    {
        [Key]
        public int STAppGridControlID { get; set; }
        public string STAppGridControlName { get; set; } = String.Empty;
        public string STAppGridControlTableName { get; set; } = String.Empty;
        public string STAppGridControlFieldGroup { get; set; } = String.Empty;
        public string STAppGridControlModuleName { get; set; } = String.Empty;
        [JsonIgnore]
        public int FK_ADuserID { get; set; }
        [JsonIgnore]
        public int FK_STAppModuleID { get; set; }
        public string STAppGridControlCaption { get; set; } = String.Empty;
        public string STAppGridControlSetting { get; set; } = String.Empty;

    }
}
