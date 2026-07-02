using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ROSearchFromProOrdr
    {
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        //public String PPPhaseCfgNo { get; set; }
        //public String PPPhaseCfgName { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; }
        //public String PPWONo { get; set; }
        //public String PPWOName { get; set; }
        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        //public String HREmployeeNo { get; set; }
        //public String HREmployeeName { get; set; }

        [JsonPropertyName("fromDate")]
        public Nullable<DateTime> fromDate { get; set; } = null;
        [JsonPropertyName("toDate")]
        public Nullable<DateTime> toDate { get; set; } = null;
    }
}
