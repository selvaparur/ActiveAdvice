using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace SpeedCarsWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // test test Selva Test 1132020 test pointcheck
            CreateWebHostBuilder(args).UseKestrel().UseIISIntegration().Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
