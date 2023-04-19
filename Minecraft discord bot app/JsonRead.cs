using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Discord.Interactions.Builders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Minecraft_discord_bot_app
{
    public class Minecraftdata
    {
        public string? Ipaddr { get; set; }
        public int Port { get; set; }
        public string? Path { get; set; }

    }

    public class Discorddata
    {
        public string? Key { get; set; }

        public long ServerKey { get; set; }

        public bool CommandAdd { get; set; }
    }

    public class Jsonimport
    {
        public string JsonString;

        public Jsonimport()
        {
            string fileName = @"setting.json";
            JsonString = File.ReadAllText(fileName);
        }
    }

    public class Portimport : Jsonimport
    {
        public int Portim() { 
        Minecraftdata? data = JsonSerializer.Deserialize<Minecraftdata>(JsonString);
        var Key = data.Port;
        return Key;
        }

    }

    public class Pathimport : Jsonimport
    {
        public string Pathim() {
            Minecraftdata? data = JsonSerializer.Deserialize<Minecraftdata>(JsonString);
            var Key = data.Path;
            return Key;
        }
    }

    public class Discordimport : Jsonimport
    {
        public string DiscordAuthKey()
        {

            Discorddata? data = JsonSerializer.Deserialize<Discorddata>(JsonString);
            return data.Key;
        }

        public ulong DiscordServerKey()
        {

            Discorddata? data = JsonSerializer.Deserialize<Discorddata>(JsonString);
            var Key = data.ServerKey;
            return (ulong)Key;
        }

        public bool CommandAdd() {
            Discorddata? data = JsonSerializer.Deserialize<Discorddata>(JsonString);
            var Key = data.CommandAdd;
            return Key;
        }
    }
}


