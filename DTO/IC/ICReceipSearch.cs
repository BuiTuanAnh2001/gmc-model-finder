using gmc_api.Base.dto;
using gmc_api.Base.Helpers;
using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.IC
{
    public class ICReceipSearch : Paging
    {
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("customerId")]
        public int FK_ARCustomerID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("nccId")]
        public int FK_APSupplierID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("no")]
        public string ICReceiptNo { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("stockId")]
        public int FK_ICStockID { get; set; } = Constants.DEFAULT_VALUE_INT;
        [JsonPropertyName("postStatus")]
        public string postStatus { get; set; } = Constants.DEFAULT_VALUE_STRING;
        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = Constants.DEFAULT_VALUE_DATETIME;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = Constants.DEFAULT_VALUE_DATETIME;
        public UserLoginInfo userInfo { get; set; } = new UserLoginInfo();
    }
}
