using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.IC
{
    public class DefaultOtherInfo
    {
        [JsonPropertyName("transConfig")]
        public List<GLTranCfgBasicInfo> transConfigs { get; set; }
        [JsonPropertyName("branchId")]
        public int branchId { get; set; }
        [JsonPropertyName("employeeId")]
        public int employeeId { get; set; }
        [JsonPropertyName("fk_currency")]
        public int currencyId { get; set; }
        [JsonPropertyName("excRate")]
        public decimal excRate { get; set; } = 1.0M;
    }
}
