using gmc_api.Base.dto;
using gmc_api.Base.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.Shipment
{
    public class ShiptmentSearch :  Paging
    {
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("customerId")]
        public int FK_ARCustomerID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("transConfigId")]
        public int FK_GLTranCfgID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("no")]
        public string ICShipmentNo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("status")]
        public string statusCombo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
