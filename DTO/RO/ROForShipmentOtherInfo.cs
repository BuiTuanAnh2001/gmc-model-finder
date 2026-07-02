using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.RO
{
    public class ROForShipmentOtherInfo
    {
        [JsonPropertyName("transConfig")]
        public List<GLTranCfgBasicInfo> transConfigs { get; set; }
        public int glOrgTranCfgID { get; set; }
        public string glOrgTranCfgName { get; set; }
        public string address { get; set; }
        [JsonPropertyName("fk_branch")]
        public int brBranchID { get; set; }
        [JsonPropertyName("fk_currency")]
        public int currencyId { get; set; }
        [JsonPropertyName("fk_employee")]
        public int FK_HREmployeeID { get; set; }
        [JsonPropertyName("excRate")]
        public decimal excRate { get; set; } = 1.0M;
        [JsonIgnore]
        public int FK_GECurrencyExObjID { get; set; }
        [JsonIgnore]
        public Nullable<DateTime> ICRODate { get; set; }
        public int FK_ICStockID { get; set; }
        public int PPCostCenterID { get; set; }
    }
}
