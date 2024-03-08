using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;
using SWAGGER_CONFIG_API;

public static class Program
{
    public static void Main(string[] agrs)
    {
        BuildHost(agrs).Build().Run();
    }

    public static IWebHostBuilder BuildHost(string[] args)
    {
        return WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>();
    }
}