using Microsoft.EntityFrameworkCore;
using MiniCoreComisiones.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios MVC y base de datos
builder.Services.AddControllersWithViews();

// Configuración de la base de datos SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Cargar datos de prueba al iniciar
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    DbInitializer.Inicializar(context);
}

// Configuración del pipeline HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto (irá a ComisionesController → Index)
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Comisiones}/{action=Index}/{id?}");

app.Run();
