using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using System;

namespace ConsoleToWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CreateHostBuilder(args).Build().Run();
            /*string url = "http://localhost:23423";
            System.Diagnostics.Process.Start(url);*/

        }
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
.ConfigureWebHost(
webHost => webHost
.UseKestrel(kestrelOptions => { kestrelOptions.ListenAnyIP(1234); })
.Configure(app => app
.Run(
async context =>
{
await context.Response.WriteAsync("Hello World!");
}
)));
        }
    }
}
