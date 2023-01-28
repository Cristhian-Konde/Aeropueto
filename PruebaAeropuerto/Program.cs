using Domio;
using Microsoft.EntityFrameworkCore;
using PruebaAeropuerto.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IAeropuertoService, AeropuertoService>();
builder.Services.AddDbContext<AeropuertoDataContext>(options =>
{
    options.UseSqlServer(builder.Configuration
        .GetConnectionString("Aeropuerto")); // for example if you're holding the connection string in the appsettings.json
});

var app = builder.Build();
//conexion


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
