using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using CoreRCON;
using Discord.WebSocket;

namespace Minecraft_discord_bot_app
{
    class Program
    {

    


        static async Task Main(string[] args)
        {
           
            await Discord_Conecct();

        }

        static async Task Discord_Conecct()
        {
            var import = new Discordimport();
            var Discord = new DiscordBot(import.DiscordServerKey(), import.CommandAdd());
            Discord.MainAsync(import.DiscordAuthKey(), import.CommandAdd()).GetAwaiter().GetResult();


        }

    }
}

