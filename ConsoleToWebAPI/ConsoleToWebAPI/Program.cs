using System;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
namespace ConsoleToWebAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //If you're configuring entity framework core than this mehtod is must.
        public static IHostBuilder CreateHostBuilder(string[] args)=>
        
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webHost =>
                {
                    webHost.UseStartup<Startup>();
                });
        
    }

}
