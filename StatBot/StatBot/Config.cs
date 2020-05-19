using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatBot
{
    public class Config
    {
        [JsonProperty("riot_api_key")]
        public string RiotAPIKey { get; set; }

        [JsonProperty("discord_token")]
        public string DiscordToken { get; set; }

        [JsonProperty("command_prefix")]
        public string CommandPrefix { get; set; }
    }
}
