using Microsoft.AspNetCore.Builder;
using Loghid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Loghid.Services;
using System;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ParametersService>();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LoghidDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

var lifetime = app.Services.GetRequiredService<IHostApplicationLifetime>();

lifetime.ApplicationStopping.Register(() =>
{
    Console.WriteLine("La aplicación se está apagando.");
});

int GenerateRandomPort()
{
    return new Random().Next(5000, 6000);
}

var port = GenerateRandomPort();
Console.WriteLine($"Iniciando la aplicación en el puerto: {port}");

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run($"http://localhost:{port}");