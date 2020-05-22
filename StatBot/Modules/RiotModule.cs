using Discord.Commands;
using StatBot.Services;
using System.Threading.Tasks;

namespace StatBot.Modules
{
    /// <summary>
    /// Commands dealing with riot api can be found in this module.
    /// </summary>
    public class RiotModule : ModuleBase<SocketCommandContext>
    {
        public ConfigService ModConfigService { get; set; }

        [Command("echo")]
        [Summary("Echos back the message.")]
        public Task EchoAsync([Remainder] string echo)
        {
            return ReplyAsync(echo);
        }

        [Command("prefix")]
        [Summary("Prints the command prefix.")]
        public Task PrefixAsync()
        {
            return ReplyAsync(ConfigService.BaseConfig.CommandPrefix.ToString());
        }
    }
}
