using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROProductionOrdrSearch : Paging
    {
        [JsonPropertyName("no")]
        public string ICRONo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("statusCombo")]
        public string ApprovalStatusCombo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("fk_wo")]
        public int FK_PPWOID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("tranCfgId")]
        public int FK_GLTranCfgID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;
        public int FK_ARCustomerID { get; set; }= Constants.DEFAULT_VALUE_INT;
        public int FK_ICProductID { get; set; } = Constants.DEFAULT_VALUE_INT;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
