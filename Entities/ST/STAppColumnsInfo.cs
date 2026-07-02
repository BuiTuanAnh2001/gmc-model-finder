using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.Entities.ST
{
    [Table("STAppColumns")]
    public class STAppColumnsInfo
    {
        [Key]
        [JsonIgnore]
        public int STAppColumnID { get; set; }
        public string STAppColumnName { get; set; } = String.Empty;
        public string STAppColumnCaption { get; set; } = String.Empty;
        public int STAppColumnIndex { get; set; }
        public bool STAppColumnShowCheck { get; set; } 
        public string STAppColumnTableName { get; set; } = String.Empty;
        public string STAppColumnModuleName { get; set; } = String.Empty;
        [JsonIgnore]
        public int FK_ADuserID { get; set; }
        public string STAppColumnSetting { get; set; } = String.Empty;
        [JsonIgnore]
        public string STAppColumnRepoDsplMem { get; set; } = String.Empty;
        [JsonIgnore]
        public string STAppColumnRepository { get; set; } = String.Empty;
        public string STAppColumnFieldGroup { get; set; } = String.Empty;
        public string STAppColumnGridName { get; set; } = String.Empty;
        [JsonIgnore]
        public int FK_STAppGridControlID { get; set; }
        [JsonIgnore]
        public int FK_STAppModuleID { get; set; }
    }
}
