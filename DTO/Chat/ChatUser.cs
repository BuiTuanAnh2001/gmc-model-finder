using System;
using Newtonsoft.Json;

namespace gmc_api.DTO.Chat
{
    public class NotifyProps
    {
        public NotifyProps(
            string email,
            string push,
            string desktop,
            string desktop_sound,
            string mention_keys,
            string channel,
            string first_name)
        {
            this.email = email;
            this.push = push;
            this.desktop = desktop;
            this.desktop_sound = desktop_sound;
            this.mention_keys = mention_keys;
            this.channel = channel;
            this.first_name = first_name;
        }

        [JsonProperty("email")]
        public string email { get; }

        [JsonProperty("push")]
        public string push { get; }

        [JsonProperty("desktop")]
        public string desktop { get; }

        [JsonProperty("desktop_sound")]
        public string desktop_sound { get; }

        [JsonProperty("mention_keys")]
        public string mention_keys { get; }

        [JsonProperty("channel")]
        public string channel { get; }

        [JsonProperty("first_name")]
        public string first_name { get; }
    }

    public class Props
    {
        // Nếu bạn cần thêm key trong tương lai thì chỉnh vào đây
        public Props() { }
    }

    public class Timezone
    {
        public Timezone(
            bool useAutomaticTimezone,
            string manualTimezone,
            string automaticTimezone)
        {
            this.useAutomaticTimezone = useAutomaticTimezone;
            this.manualTimezone = manualTimezone;
            this.automaticTimezone = automaticTimezone;
        }

        [JsonProperty("useAutomaticTimezone")]
        public bool useAutomaticTimezone { get; }

        [JsonProperty("manualTimezone")]
        public string manualTimezone { get; }

        [JsonProperty("automaticTimezone")]
        public string automaticTimezone { get; }
    }

    public class ChatUser
    {
        // --- Common fields ---
        [JsonProperty("username")]
        public string Username { get; private set; } = string.Empty;

        [JsonProperty("email")]
        public string Email { get; private set; } = string.Empty;

        [JsonProperty("first_name")]
        public string? FirstName { get; private set; }

        [JsonProperty("last_name")]
        public string? LastName { get; private set; }

        [JsonProperty("nickname")]
        public string? Nickname { get; private set; }

        [JsonProperty("timezone")]
        public Timezone? Timezone { get; private set; }

        [JsonProperty("props")]
        public Props? Props { get; private set; }

        [JsonProperty("notify_props")]
        public NotifyProps? NotifyProps { get; private set; }

        [JsonProperty("auth_service")]
        public string? AuthService { get; private set; }

        [JsonProperty("auth_data")]
        public string? AuthData { get; private set; }

        [JsonProperty("locale")]
        public string? Locale { get; private set; }

        [JsonProperty("position")]
        public string? Position { get; private set; }

        // --- Request only ---
        [JsonProperty("password")]
        public string? Password { get; private set; }

        // --- Response only ---
        [JsonProperty("id")]
        public string? Id { get; private set; }

        [JsonProperty("create_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]

        public DateTime? CreateAt { get; private set; }

        [JsonProperty("update_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? UpdateAt { get; private set; }

        [JsonProperty("delete_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? DeleteAt { get; private set; }

        [JsonProperty("email_verified")]
        public bool? EmailVerified { get; private set; }

        [JsonProperty("roles")]
        public string? Roles { get; private set; }

        [JsonProperty("last_password_update")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? LastPasswordUpdate { get; private set; }

        [JsonProperty("last_picture_update")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? LastPictureUpdate { get; private set; }

        [JsonProperty("failed_attempts")]
        public int? FailedAttempts { get; private set; }

        [JsonProperty("mfa_active")]
        public bool? MfaActive { get; private set; }

        [JsonProperty("terms_of_service_id")]
        public string? TermsOfServiceId { get; private set; }

        [JsonProperty("terms_of_service_create_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? TermsOfServiceCreateAt { get; private set; }

        // --- Factory methods ---
        public static ChatUser Request(
            string email,
            string username,
            string password,
            string? firstName = null,
            string? lastName = null,
            string? nickname = null,
            string? position = null,
            Timezone? timezone = null,
            string? authData = null,
            string? authService = null,
            string? locale = null,
            Props? props = null,
            NotifyProps? notifyProps = null)
        {
            return new ChatUser
            {
                Email = email,
                Username = username,
                Password = password,
                FirstName = firstName,
                LastName = lastName,
                Nickname = nickname,
                Position = position,
                Timezone = timezone,
                AuthData = authData,
                AuthService = authService,
                Locale = locale,
                Props = props,
                NotifyProps = notifyProps
            };
        }

        public static ChatUser Response(
            string id,
            DateTime createAt,
            DateTime updateAt,
            DateTime deleteAt,
            string username,
            string firstName,
            string lastName,
            string nickname,
            string email,
            bool emailVerified,
            string authService,
            string roles,
            string locale,
            NotifyProps notifyProps,
            Props props,
            DateTime lastPasswordUpdate,
            DateTime lastPictureUpdate,
            int failedAttempts,
            bool mfaActive,
            Timezone timezone,
            string termsOfServiceId,
            DateTime termsOfServiceCreateAt)
        {
            return new ChatUser
            {
                Id = id,
                CreateAt = createAt,
                UpdateAt = updateAt,
                DeleteAt = deleteAt,
                Username = username,
                FirstName = firstName,
                LastName = lastName,
                Nickname = nickname,
                Email = email,
                EmailVerified = emailVerified,
                AuthService = authService,
                Roles = roles,
                Locale = locale,
                NotifyProps = notifyProps,
                Props = props,
                LastPasswordUpdate = lastPasswordUpdate,
                LastPictureUpdate = lastPictureUpdate,
                FailedAttempts = failedAttempts,
                MfaActive = mfaActive,
                Timezone = timezone,
                TermsOfServiceId = termsOfServiceId,
                TermsOfServiceCreateAt = termsOfServiceCreateAt
            };
        }
    }
}
