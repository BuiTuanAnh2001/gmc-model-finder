using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.IC
{
    public class SearchRequestReceipts
    {
        public string no { get; set; } = string.Empty;
        public string fromdate { get; set; }=Constants.DEFAULT_VALUE_STRING;
        public string todate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public int FK_ICProductID { get; set; } = Constants.DEFAULT_VALUE_INT;
    }
    
}
