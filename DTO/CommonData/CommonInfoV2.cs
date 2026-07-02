using System.Text.Json.Serialization;

namespace gmc_api.DTO.CommonData
{
    public class CommonInfoV2
    {
        [JsonPropertyName("no")]
        public string objNo { get; set; }
        [JsonPropertyName("name")]
        public string objName { get; set; }
        [JsonPropertyName("id")]
        public int objId { get; set; }
    }
}
