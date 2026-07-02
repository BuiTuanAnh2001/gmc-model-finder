using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemIcode
{
    public class SearchDataICode
    {
        public string fromDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string toDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public int iCodeId { get; set; }
    }
}
