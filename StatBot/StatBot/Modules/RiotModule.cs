using Discord.Commands;
using System.Threading.Tasks;

namespace StatBot.Modules
{    
    public class RiotModule : ModuleBase<SocketCommandContext>
    {
        [Command("echo")]
        public Task EchoAsync([Remainder] string echo)
        {
            return ReplyAsync(echo);
        }
    }
}
