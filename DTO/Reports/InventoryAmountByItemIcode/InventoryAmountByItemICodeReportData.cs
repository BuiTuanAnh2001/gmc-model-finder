using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using gmc_api.Base.Helpers;

namespace gmc_api.DTO.Reports.InventoryAmountByItemIcode
{
    public class InventoryAmountByItemICodeReportData
    {
        public List<ProTypeICode> ProType { get; set; }
        public List<TimeTypeICode> TimeType { get; set; }
        public List<MonthTypeICode> MonthType { get; set; }
        public List<MonthTotalICode> MonthTotal { get; set; }
    }
}
