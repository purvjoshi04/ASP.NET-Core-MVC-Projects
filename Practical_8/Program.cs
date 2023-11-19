using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();


async Task<string> DownloadFromUrlAsync(string url)
{
    using var client = new HttpClient();
    var response = await client.GetAsync(url);

    if (response.IsSuccessStatusCode)
    {
        return await response.Content.ReadAsStringAsync();
    }
    else
    {
        throw new Exception($"Failed to download data from {url}. Status code: {response.StatusCode}");
    }
}

app.MapGet("/", async context =>
{
    var webUrl = "https://jsonplaceholder.typicode.com/todos/"; 

    try
    {
        var downloadedData = await DownloadFromUrlAsync(webUrl);

        var fileName = "todo.txt";
        await context.Response.WriteAsync($"<a href='data:text/plain;charset=utf-8,{Uri.EscapeDataString(downloadedData)}' download='{fileName}'>Download {fileName}</a>");

      
        await context.Response.WriteAsync($"<pre>{downloadedData}</pre>");
    }
    catch (Exception ex)
    {
        await context.Response.WriteAsync($"Error: {ex.Message}");
    }
});





app.Run();
