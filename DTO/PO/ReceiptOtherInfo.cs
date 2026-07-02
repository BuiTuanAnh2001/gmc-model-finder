using gmc_api.DTO.dto;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PO
{
    public class ReceiptOtherInfo
    {
        [JsonPropertyName("transConfig")]
        public List<GLTranCfgBasicInfo> transConfigs { get; set; }
        public int glOrgTranCfgID { get; set; }
        public string glOrgTranCfgName { get; set; }
        [JsonPropertyName("fk_branch")]
        public int brBranchID { get; set; }
        [JsonPropertyName("fk_currency")]
        public int currencyId { get; set; }
        [JsonPropertyName("excRate")]
        public decimal excRate { get; set; } = 1.0M;
        [JsonIgnore]
        public int FK_GECurrencyExObjID { get; set; }
        [JsonIgnore]
        public Nullable<DateTime> documentDate { get; set; }
        public int FK_ICStockID { get; set; }
        public int FK_HREmployeeID { get; set; }
    }
}
