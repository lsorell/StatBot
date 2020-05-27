using Newtonsoft.Json;

namespace StatBot
{
    /// <summary>
    /// Config object for json deserialization.
    /// </summary>
    public class Config
    {
        [JsonProperty("riot_api_key")]
        public string RiotAPIKey { get; set; }

        [JsonProperty("discord_token")]
        public string DiscordToken { get; set; }

        /// <summary>
        /// The prefix the discord bot will use to recognize a command.
        /// </summary>
        [JsonProperty("command_prefix")]
        public char CommandPrefix { get; set; }
    }
}
