using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPResourcesBasic
    {
        [JsonPropertyName("resourceId")]
        public int PPResourceID { get; set; }
        [JsonPropertyName("resourceNo")]
        public string PPResourceNo{ get; set; }
        [JsonPropertyName("resourceName")]
        public string PPResourceName { get; set; }

    }
}
