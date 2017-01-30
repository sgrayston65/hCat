using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace HCSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel() // webserver hosting the app
                .UseContentRoot(Directory.GetCurrentDirectory()) 
                .UseIISIntegration()  // reverse proxy for kestrel
                .UseStartup<Startup>() // use startup.cs
                .Build(); // builds an IWebHost

            host.Run();
        }
    }
}
