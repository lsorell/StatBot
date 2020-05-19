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

        /// <summary>
        /// The prefix the discord bot will use to recognize a command.
        /// </summary>
        [JsonProperty("command_prefix")]
        public char CommandPrefix { get; set; }
    }
}
