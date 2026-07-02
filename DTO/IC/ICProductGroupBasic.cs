using System;
using System.Text.Json.Serialization;

namespace gmc_api.Base.dto
{
    public class ICProductGroupBasic
    {
        [JsonPropertyName("productGroupId")]
        public int ICProductGroupID { get; set; }
        [JsonPropertyName("productGroupNo")]
        public string ICProductGroupNo { get; set; }
        [JsonPropertyName("productGroupName")]
        public string ICProductGroupName { get; set; }
    }
}
