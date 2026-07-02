using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemType
{
    public class InventoryAmountByItemTypeReportData
    {
        public List<ProType> ProType { get; set; }
        public List<TimeType> TimeType { get; set; }
        public List<MonthType> MonthType { get; set; }
        public List<MonthTotal> MonthTotal { get; set; }
    }
}
