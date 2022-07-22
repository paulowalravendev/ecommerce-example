var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

var apiAddress = "https://localhost:5001";

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiAddress) });

await builder.Build().RunAsync();