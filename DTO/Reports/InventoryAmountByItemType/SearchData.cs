using System;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemType
{
    public class SearchData
    {
        public string fromDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
        public string toDate { get; set; } = Constants.DEFAULT_VALUE_STRING;
    }
}
