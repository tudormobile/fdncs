using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using Tudormobile.FinancialData;
using Tudormobile.FinancialData.Extensions;

namespace ExtendedConsoleApp;

internal class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Setup Host with Financial Data Client
        HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

        builder.Services
            .AddFinancialDataClient(options => { options.WithApiKey("your-api-key"); })
            .AddLogging(builder => builder.AddConsole());

        using IHost host = builder.Build();
        var logger = host.Services.GetRequiredService<ILogger<Program>>();

        // Grab a client
        var client = host.Services.GetRequiredService<IFinancialDataClient>();

        // Get stock prices for Apple
        var response = await client.GetStockPricesAsync("AAPL");
        if (response.IsSuccess && response.Data is not null)
        {
            var aapl = response.Data.First();
            Console.WriteLine($"Apple closed at {aapl.Close} on {aapl.Date}");
        }
        else
        {
            Console.WriteLine(response.Error);
        }
    }
}
