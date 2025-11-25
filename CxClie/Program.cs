using System.Net.Http.Headers;

using Blazored.LocalStorage;

using CxClie;
using CxClie.Services;

using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Register Blazored.LocalStorage
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazorBootstrap();

//Base client
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Register authentication services
builder.Services.AddAuthorizationCore();
//builder.Services.AddCascadingAuthenticationState();

builder.Services.AddScoped<MyMultAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp => sp.GetRequiredService<MyMultAuthStateProvider>());

// Register handler classes
builder.Services.AddTransient<ApiGxAuthorizationHandler>();
builder.Services.AddTransient<ApiCustAuthorizationHandler>();
// Register named HttpClients with handlers
builder.Services.AddHttpClient("ApiGxClient", client =>
{
    var backUrl = builder.Configuration["BackendUrl"];
    backUrl = backUrl.TrimEnd('/');
    backUrl += "/";
    client.BaseAddress = new Uri(backUrl);
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.Add("X-Requested-With", "Fetch");
    //client.BaseAddress = new Uri("https://api2.example.com/");
})
.AddHttpMessageHandler<ApiGxAuthorizationHandler>();

builder.Services.AddHttpClient("ApiCustClient")
    .AddHttpMessageHandler<ApiCustAuthorizationHandler>();
builder.Services.AddScoped<IDynamicApiClientService, DynamicApiClientService>();
builder.Services.AddScoped<IFrontendLoginService, FrontendLoginService>();
builder.Services.AddHttpClient("LocalClient", client =>
{
    // The BaseAddress property expects a Uri, so you can pass the Uri object directly.
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});
//builder.Services.AddHttpClient("api")
//    .AddHttpMessageHandler<ApiCustAuthorizationHandler>();

//customer website client
builder.Services.AddScoped<IFrontendLoginService, FrontendLoginService>();
//services suite
builder.Services.AddScoped<TblJsonRender>();
builder.Services.AddScoped<LinkSerialiser>();
builder.Services.AddSingleton<AppState>();

await builder.Build().RunAsync();
