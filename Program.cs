using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;

namespace WasmTest;

public class Program
{
    private static IJSRuntime js;

    private static async Task Main (string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        var host = builder.Build();
        js = host.Services.GetRequiredService<IJSRuntime>();
        await host.RunAsync();
    }

    [JSInvokable]
    public static async Task<string> BuildMessage (string name)
    {
        var time = await GetTimeViaJS();
        return $"Hello {name}! Current time is {time}.";
    }

    public static async Task<DateTime> GetTimeViaJS ()
    {
        return await js.InvokeAsync<DateTime>("getTime");
    }
}
