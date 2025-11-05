using System.Net.Http.Headers;

using CxClie;
using CxClie.Services;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazorBootstrap();

//Base client
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//Specific client //webApiClient
builder.Services.AddHttpClient("wApiClient", client =>
{
    var backUrl = builder.Configuration["BackendUrl"];
    backUrl = backUrl.TrimEnd('/');
    backUrl += "/api/";
    client.BaseAddress = new Uri(backUrl);
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.Add("X-Requested-With", "Fetch");
});
builder.Services.AddHttpClient("simpleApiClient", client =>
{
    var backUrl = builder.Configuration["BackendUrl"];
    backUrl = backUrl.TrimEnd('/');
    backUrl += "/"; //simple without api
    client.BaseAddress = new Uri(backUrl);
    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
    client.DefaultRequestHeaders.Add("X-Requested-With", "Fetch");
});
builder.Services.AddHttpClient("localClient", client =>
{
    // The BaseAddress property expects a Uri, so you can pass the Uri object directly.
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
});
builder.Services.AddScoped<TblJsonRender>();
//builder.Services.AddScoped<LinkSerialiser>();

await builder.Build().RunAsync();
