using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPToolManagementDetailsCreateRequest
    {
        [JsonPropertyName("toolManagementDetailId")]
        public int PPToolManagementDetailID { get; set; }
        [JsonPropertyName("toolManagementId")]
        public int FK_PPToolManagementID { get; set; }
        [JsonPropertyName("toolId")]
        public int FK_ICToolProductID { get; set; }
    }
}
