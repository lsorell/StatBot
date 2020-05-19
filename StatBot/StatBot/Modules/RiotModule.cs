using Discord.Commands;
using System.Threading.Tasks;

namespace StatBot.Modules
{    
    public class RiotModule : ModuleBase<SocketCommandContext>
    {
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
    }
}
