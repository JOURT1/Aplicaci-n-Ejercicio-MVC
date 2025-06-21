using Microsoft.EntityFrameworkCore;
using MiniCoreComisiones.Data;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios MVC y base de datos
builder.Services.AddControllersWithViews();

// Configuración de la base de datos SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Aplicar migraciones y cargar datos de prueba
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();

    context.Database.Migrate(); // ✅ Aplica migraciones automáticamente en producción
    DbInitializer.Inicializar(context); // ✅ Carga datos si no existen
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

// Ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Comisiones}/{action=Index}/{id?}");

app.Run();
