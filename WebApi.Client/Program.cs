using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
Console.WriteLine("Hello");
await builder.Build().RunAsync();
