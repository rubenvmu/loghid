using Microsoft.AspNetCore.Builder;
using Loghid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Agregar Razor Pages
builder.Services.AddRazorPages();

// Configurar DbContext con SQLite
builder.Services.AddDbContext<LoghidDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));


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
    return new Random().Next(5000, 6000);  // Asegúrate de que este rango no esté siendo utilizado.
}

var port = GenerateRandomPort();
Console.WriteLine($"Iniciando la aplicación en el puerto: {port}");

// Configuración para el manejo de excepciones y redirección a HTTPS
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");  // Página de error en caso de excepciones.
    app.UseHsts();  // Activar HTTP Strict Transport Security (HSTS)
}

app.UseHttpsRedirection();  // Redirección a HTTPS
app.UseStaticFiles();  // Servir archivos estáticos (por ejemplo, imágenes, JS, CSS)
app.UseRouting();  // Habilitar el enrutamiento
app.UseAuthorization();  // Habilitar autorización

// Mapear Razor Pages
app.MapRazorPages();

// Iniciar la aplicación en el puerto generado dinámicamente
app.Run($"http://localhost:{port}");