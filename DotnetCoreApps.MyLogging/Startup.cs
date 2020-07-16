using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace DotnetCoreApps.MyLogging
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //https://www.tutorialsteacher.com/core/fundamentals-of-logging-in-dotnet-core


            /*
             * ILoggerFactory loggerFactory = new LoggerFactory().AddConsole((_, __) => true);
            ILogger logger = loggerFactory.CreateLogger<Program>();
    
            logger.LogInformation("Logging information.");
            logger.LogCritical("Logging critical information.");
            logger.LogDebug("Logging debug information.");
            logger.LogError("Logging error information.");
            logger.LogTrace("Logging trace");
            logger.LogWarning("Logging warning.");
             */


            ILoggerFactory loggerFactory = new LoggerFactory(
                new[] { new ConsoleLoggerProvider((_, __) => true, true) }
            );
            //or
            //ILoggerFactory loggerFactory = new LoggerFactory().AddConsole();

            ILogger logger = loggerFactory.CreateLogger<Program>();
            logger.LogInformation("This is log message.");

            //info: DotnetCoreConsoleApp.Program[0]
            //This is log message. 




            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}
