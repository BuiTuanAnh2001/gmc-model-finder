using Newtonsoft.Json;

namespace gmc_api.DTO.Chat
{
    public class ChatUserToken
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("token")]
        public string Token { get; set; } = string.Empty;

        [JsonProperty("user_id")]
        public string UserId { get; set; } = string.Empty;

        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;

        [JsonProperty("is_active")]
        public bool IsActive { get; set; } = false;
    }
}