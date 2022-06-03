using ConsoleAppFramework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

using AlienCell.ConsoleApp.Apps;
using AlienCell.ConsoleApp.Data;
using AlienCell.Shared.Data;


namespace AlienCell.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var builder = ConsoleAppFramework.ConsoleApp.CreateBuilder(args);
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<DatabaseBuilder>();
                services.AddSingleton<GameDataBuilder>();
            });

            var app = builder.Build();

            app.AddSubCommands<GameDataApp>();

            app.Run();
        }
    }
}

