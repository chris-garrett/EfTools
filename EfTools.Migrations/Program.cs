using System;

namespace EfTools.Migrations
{
    class Program
    {
        public static int Main(string[] args)
        {
            /*
            var app = new CommandLineApplication();
            
            app.HelpOption("-h|--help");
            var optionTimeout = app.Option<int>("-t|--timeout <N>", "Timeout in minutes. Default is 600 min (10 hrs)", CommandOptionType.SingleValue);
            var optionListen = app.Option("-l|--listen", "Start server that listens on port (5000). Useful for running in a container", CommandOptionType.NoValue);
            
            app.OnExecuteAsync(async cancellationToken =>
            {
                var host = CreateHostBuilder(args).Build();

                using (var serviceScope = host.Services.CreateScope())
                {
                    var log = serviceScope.ServiceProvider.GetRequiredService<ILogger<Program>>();
                    var ctx = new PostgresDesignTimeContextFactory().CreateDbContext(new string[]{});

                    int timeout = optionTimeout.HasValue() 
                        ? (int)TimeSpan.FromMinutes(optionTimeout.ParsedValue).TotalSeconds  
                        : (int) TimeSpan.FromHours(10).TotalSeconds;
                    ctx.Database.SetCommandTimeout(timeout);
                
                    log.LogInformation($"Starting migrations (timeout {timeout} sec)");
                    await ctx.Database.MigrateAsync();
                    log.LogInformation($"Finished migrations");
                }

                if (optionListen.HasValue())
                {
                    await host.RunAsync(cancellationToken);
                }
            });

            return app.Execute(args);
            */
            return 0;
        }
    }
}
