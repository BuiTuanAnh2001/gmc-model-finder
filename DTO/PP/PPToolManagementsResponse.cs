using System;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPToolManagementsResponse
    {
        [JsonPropertyName("toolManagementId")]
        public int PPToolManagementID { get; set; }
        [JsonPropertyName("toolManagementNo")]
        public string PPToolManagementNo { get; set; }
        [JsonPropertyName("toolManagementName")]
        public string PPToolManagementName { get; set; }
        [JsonPropertyName("toolManagementDesc")]
        public string PPToolManagementDesc { get; set; }
        [JsonPropertyName("productId")]
        public int FK_ICProductID { get; set; }
        [JsonPropertyName("resourceId")]
        public int FK_PPResourceID { get; set; }
    }
}
