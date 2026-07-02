using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace gmc_api.DTO.PP
{
    public class PPToolManagementsBasic
    {
        [JsonPropertyName("toolManagementId")]
        public int PPToolManagementID { get; set; }
        [JsonPropertyName("toolManagementNo")]
        public string PPToolManagementNo { get; set; }
        [JsonPropertyName("toolManagementName")]
        public string PPToolManagementName { get; set; }

    }
}
