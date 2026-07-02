using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class PrdOrderFroShipmentOtherInfo
    {
        [JsonPropertyName("transConfig")]
        public List<GLTranCfgBasicInfo> transConfigs { get; set; }
        public int glOrgTranCfgID { get; set; }
        [JsonPropertyName("fk_branch")]
        public int brBranchID { get; set; }
        [JsonPropertyName("employeeId")]
        public int employeeId { get; set; }
        [JsonPropertyName("currecyId")]
        public int currecyId { get; set; }
        [JsonPropertyName("description")]
        public string description { get; set; }
        [JsonPropertyName("shipmentTypeId")]
        public int shipmentTypeId { get; set; }
        public int FK_ICStockID { get; set; }
        public int PPCostCenterID { get; set; }
    }
}
