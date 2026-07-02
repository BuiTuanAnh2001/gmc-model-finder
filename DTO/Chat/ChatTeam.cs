using System;
using Newtonsoft.Json;

namespace gmc_api.DTO.Chat
{
    public class ChatTeam
    {
        [JsonProperty("id")]
        public string? Id { get; set; } = null;

        [JsonProperty("create_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? CreateAt { get; set; }

        [JsonProperty("update_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UpdateAt { get; set; }

        [JsonProperty("delete_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DeleteAt { get; set; }

        [JsonProperty("display_name")]
        public string? DisplayName { get; set; } = null;

        [JsonProperty("name")]
        public string? Name { get; set; } = null;

        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        [JsonProperty("email")]
        public string? Email { get; set; } = null;

        [JsonProperty("type")]
        /// <summary>
        /// O = Open, I = Invite only
        /// </summary>
        public char? Type { get; set; } = 'O';

        [JsonProperty("allowed_domains")]
        public string? AllowedDomains { get; set; } = null;

        [JsonProperty("invite_id")]
        public string? InviteId { get; set; } = null;

        [JsonProperty("allow_open_invite")]
        public bool? AllowOpenInvite { get; set; } = false;

        [JsonProperty("policy_id")]
        public string? PolicyId { get; set; } = null;
    }
}