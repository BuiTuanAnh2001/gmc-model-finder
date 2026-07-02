using gmc_api.Base.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace gmc_api.DTO.PP
{
    public class ProductionOderWebResponse : NumberRecord
    {
        [JsonPropertyName("id")]
        public int PPProductionOrdrID { get; set; }
        [JsonPropertyName("no")]
        public string PPProductionOrdrNo { get; set; }
        [JsonPropertyName("ordrDate")]
        public Nullable<DateTime> PPProductionOrdrDate { get; set; }
        [JsonPropertyName("phaseId")]
        public int FK_PPPhaseCfgID { get; set; }
        [JsonPropertyName("description")]
        public string PPProductionOrdrDesc { get; set; }
        [JsonPropertyName("status")]
        public string PPProductionOrdrStatus { get; set; }
        [JsonPropertyName("qcStatus")]
        public string PPProductionOrdrQCStatusCombo { get; set; }
        [JsonPropertyName("lotNo")]
        public string PPProductionOrdrLotNo { get; set; }
        [JsonPropertyName("resourceId")]
        public int FK_PPResourceID { get; set; }
        [JsonPropertyName("workOrderId")]
        public int FK_PPWOID { get; set; }
        [JsonPropertyName("tranCfgId")]
        public int FK_GLTranCfgID { get; set; }
        public string jobTicketName { get; set; }
        [JsonPropertyName("estStartDate")]
        public Nullable<DateTime> PPProductionOrdrEstStartDate { get; set; }
        [JsonPropertyName("estEndDate")]
        public Nullable<DateTime> PPProductionOrdrEstEndDate { get; set; }
        [JsonPropertyName("actStartDate")]
        public Nullable<DateTime> PPProductionOrdrActStartDate { get; set; }
        [JsonPropertyName("actEndDate")]
        public Nullable<DateTime> PPProductionOrdrActEndDate { get; set; }
        [JsonPropertyName("employeeId")]
        public int FK_HREmployeeID { get; set; }
        [JsonPropertyName("branchId")]
        public int FK_BRBranchID { get; set; }
    }
}
