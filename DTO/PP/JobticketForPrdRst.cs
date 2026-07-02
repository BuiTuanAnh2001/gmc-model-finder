using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class JobticketForPrdRst
    {
        [JsonPropertyName("id")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("workOrderId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
        [JsonPropertyName("ordDate")]
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("description")]
        public string PPProductionOrdrDesc { get; set; }
        [JsonPropertyName("workCenterId")]
        public int FK_PPWorkCenterID { get; set; }
        [JsonPropertyName("resourceId")]
        public int FK_PPResourceID { get; set; }

    }
}
