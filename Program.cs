using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;

namespace MyWorldWebAPIDocker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //(CDLTLL) If using Command Line, something like:
            // dotnet run --server.urls "http://localhost:7777;http://*:7000" 
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                //(CDLTLL) .SetBasePath(Directory.GetCurrentDirectory())  //(CDLTLL)
                //(CDLTLL) .AddJsonFile("hosting.json", optional: true)   //(CDLTLL)
                .AddEnvironmentVariables(prefix: "ASPNETCORE_")
                .Build();
            
            var host = new WebHostBuilder()
                .UseConfiguration(config)
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}


