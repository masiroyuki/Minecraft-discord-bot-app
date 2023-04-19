using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Tar;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Net;
using Discord.WebSocket;
using Newtonsoft.Json;

namespace Minecraft_discord_bot_app
{
    public class DiscordBot
    {
        public DiscordSocketClient _client;
        ulong Key;
        public static bool x = false;
        bool y = false;

        public DiscordBot(ulong key,bool x)
        {
            this.Key = key;
            this.y = x;
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }
        public async Task MainAsync(string Key,bool i)
        {
            _client = new DiscordSocketClient();

            _client.Log += Log;

            if (y)
              {
                Console.WriteLine("コマンド追加処理を実行します。");
                  _client.Ready += Add;
              }
            
            _client.SlashCommandExecuted += SlashCommandHandler;

            await _client.LoginAsync(TokenType.Bot, Key);
            await _client.StartAsync();
            await Task.Delay(-1);
        }

        public async Task Add()
        {
            foreach (string Value in new DiscordCommand().command.Values)
            {
                var guild = _client.GetGuild(Key);
                var guildCommand = new SlashCommandBuilder();
                guildCommand.WithName(Value);
                guildCommand.WithDescription("説明なし");
                try
                {
                    await guild.CreateApplicationCommandAsync(guildCommand.Build());

                }

                catch (ApplicationCommandException exception)
                {
                    var json = JsonConvert.SerializeObject(exception.Errors, Formatting.Indented);
                    Console.WriteLine(json);

                }
            }
        }

        public async Task SlashCommandHandler(SocketSlashCommand command)
        {
            var port = new Portimport();
            if (IpSend.PortScan(port.Portim()))
            {
    
                await command.RespondAsync($"すでに起動しています。");
            }
            else if(x) {
                await command.RespondAsync($"現在起動処理中です。時間を空けてお試しください。");
            }
            else {
                await command.RespondAsync($"実行しました {command.Data.Name}");
                var app = new ProcessStartInfo();
                var path = new Pathimport();
                app.FileName = path.Pathim();
                app.WorkingDirectory = Path.GetDirectoryName(path.Pathim());
                app.UseShellExecute = true;
                Process.Start(app);
                x = true;
                Task.Run (() => { IpSend.Timedlay(); });
                
            }
            
        }
    }

    class IpSend
    {
        public static bool PortScan(int port)
        {
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpConnInfoArray = ipGlobalProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endpoint in tcpConnInfoArray)
            {
                Console.WriteLine(endpoint.Port);
                 if (endpoint.Port == port){
                    return true;
                }

            }
            return false;
            

        }

        public static async Task Timedlay()
        {
            await Task.Delay(120000);
            DiscordBot.x = false;
        } 


    }
}


