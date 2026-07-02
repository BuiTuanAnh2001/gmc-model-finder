using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using gmc_api.Base.dto;

namespace gmc_api.DTO.ROProductionOrdr
{
    public class ProOrdrForRO
    {
        [JsonPropertyName("jobticketId")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("jobticketNo")]
        public String PPProductionOrdrNo { get; set; }
        [JsonPropertyName("date")]
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("phaseNo")]
        public String PPPhaseCfgNo { get; set; }
        [JsonPropertyName("phaseName")]
        public String PPPhaseCfgName { get; set; }
        [JsonPropertyName("woId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("woNo")]
        public String PPWONo { get; set; }
        [JsonPropertyName("woName")]
        public String PPWOName { get; set; }
        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        [JsonPropertyName("employeeNo")]
        public String HREmployeeNo { get; set; }
        [JsonPropertyName("employeeName")]
        public String HREmployeeName { get; set; }

    }
}
