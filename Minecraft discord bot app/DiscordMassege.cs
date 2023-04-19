using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft_discord_bot_app
{
    public class DiscordMassege
    {
        public Dictionary<string, string> reply = new Dictionary<string, string>()
        {
            {"start","サーバーを起動します。" },
            //{"stop","サーバーを停止します。" },
        };

    }
        public class DiscordCommand
    {
        public Dictionary<int, string> command = new Dictionary<int, string>()
        {
            {0,"start"},
            //{1,"stop" },
        };

    }
}
