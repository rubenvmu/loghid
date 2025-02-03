using Microsoft.AspNetCore.Builder;
using Loghid.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Loghid.Services;



var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<ParametersService>();
builder.Services.AddRazorPages();

builder.Services.AddDbContext<LoghidDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

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

app.Run();