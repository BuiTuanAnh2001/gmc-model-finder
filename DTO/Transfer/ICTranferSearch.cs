using gmc_api.Base.dto;
using gmc_api.Base.Helpers;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.Transfer
{
    public class ICTranferSearch : Paging
    {
        [JsonPropertyName("no")]
        public string ICTransferNo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("serialNo")]
        public string serialNo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; } = Constants.DEFAULT_VALUE_INT;

        [JsonPropertyName("fromStockId")]
        public int fromStockId { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("toStockId")]
        public int toStockId { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
