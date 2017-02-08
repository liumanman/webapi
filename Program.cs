using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                // .UseUrls("http://localhost:5001")
                .ConfigureServices(services => services.AddMvc())
                // .UseContentRoot(Directory.GetCurrentDirectory())
                // .UseIISIntegration()
                // .UseStartup<Startup>()
                .Configure(app => app.UseMvc())
                .Build();

            host.Run();
        }
    }
}
