using Discord.Commands;
using StatBot.Services;
using System.Threading.Tasks;

namespace StatBot.Modules
{
    public class RiotModule : ModuleBase<SocketCommandContext>
    {
        public ConfigService ConfigService { get; set; }

        /// <summary>
        /// Echo's back the string after the command.
        /// </summary>
        /// <param name="echo">The string to echo.</param>
        /// <returns></returns>
        [Command("echo")]
        public Task EchoAsync([Remainder] string echo)
        {            
            return ReplyAsync(echo);
        }

        [Command("prefix")]
        public Task PrefixAsync()
        {
            return ReplyAsync(ConfigService.Config.CommandPrefix.ToString());
        }
    }
}
