using System;
using System.Net.Http;
using System.Threading.Tasks;
using Blazorise;
using Blazorise.Bootstrap;
using Blazorise.Icons.FontAwesome;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GuidGen.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Logging.SetMinimumLevel(LogLevel.Debug);

            builder.RootComponents.Add<App>("#app");

            builder.Services
                .AddScoped(sp => new HttpClient {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)})
                .AddBlazorise(options => { options.ChangeTextOnKeyPress = true; })
                .AddBootstrapProviders()
                .AddFontAwesomeIcons();

            var host = builder.Build();

            await host.RunAsync();
        }
    }
}