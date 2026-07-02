using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPErrorCodeResultsCreateRequest
    {
        [JsonPropertyName("productionOrdrId")]
        public int FK_PPProductionOrdrID { get; set; }
        [JsonPropertyName("productionOrdrEstFGId")]
        public int FK_PPProductionOrdrEstFGID { get; set; }
        [JsonPropertyName("errorCodeResultId")]
        public int PPErrorCodeResultID { get; set; } = 0;
        [JsonPropertyName("errorCodeResultNo")]
        public string PPErrorCodeResultNo { get; set; }
        [JsonPropertyName("errorCodeResultName")]
        public string PPErrorCodeResultName { get; set; }
        [JsonPropertyName("errorCodeResultDate")]
        public Nullable<DateTime> PPErrorCodeResultDate { get; set; } = DateTime.Now;
        [JsonPropertyName("errorCodeResultUser")]
        public string PPErrorCodeResultUser { get; set; }
        [JsonPropertyName("errorCodeResultStatus")]
        public string PPErrorCodeResultStatus { get; set; }
        [JsonPropertyName("errorCodeResultDesc")]
        public string PPErrorCodeResultDesc { get; set; }
        
    }
}
