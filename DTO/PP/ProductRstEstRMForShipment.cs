using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class ProductRstEstRMForShipment
    {
        [JsonPropertyName("id")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        [JsonPropertyName("description")]
        public string PPProductionOrdrDesc { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("workOrderId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        [JsonPropertyName("employeeName")]
        public string employeeName { get; set; }
        [JsonPropertyName("jobticketName")]
        public string jobticketName { get; set; }
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; } = 0;
    }
}
