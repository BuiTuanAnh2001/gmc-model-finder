using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROForTransferOtherInfo
    {
        [JsonPropertyName("transConfig")]
        public List<GLTranCfgBasicInfo> transConfigs { get; set; }
        public int glOrgTranCfgID { get; set; }
        public string glOrgTranCfgName { get; set; }
        [JsonPropertyName("fromSktId")]
        public int fromSktId { get; set; }
        [JsonPropertyName("toSktId")]
        public int toSktId { get; set; }

        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        [JsonIgnore]
        public Nullable<DateTime> ICRODate { get; set; }

        [JsonPropertyName("fk_branch")]
        public int brBranchID { get; set; }
        [JsonPropertyName("fromSktItemId")]
        public int fromSktItemId { get; set; }
        [JsonPropertyName("toSktItemId")]
        public int toSktItemId { get; set; }
    }
}
