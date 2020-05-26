using Discord.Commands;
using StatBot.Services;
using System.Threading.Tasks;

namespace StatBot.Modules
{
    public class RiotModule : ModuleBase<SocketCommandContext>
    {
        public ConfigService ConfigService { get; set; }
        
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
