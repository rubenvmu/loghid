using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Loghid.Data;
using System;

var builder = WebApplication.CreateBuilder(args);

// Configurar DbContext con SQLite
builder.Services.AddDbContext<LoghidDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<LoghidClientMeasurementDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("SecondaryConnection")));


builder.Services.AddRazorPages();

var app = builder.Build();

// Obtener el ciclo de vida de la aplicación para registrar eventos al detenerse
var lifetime = app.Services.GetRequiredService<IHostApplicationLifetime>();
lifetime.ApplicationStopping.Register(() =>
{
    Console.WriteLine("La aplicación se está apagando.");
});

// Generar un puerto aleatorio dentro de un rango válido
int GenerateRandomPort()
{
    return new Random().Next(5000, 6000);  // Asegurar que este rango esté libre
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

// Ejecutar la aplicación en el puerto dinámico
app.Run($"http://localhost:{port}");