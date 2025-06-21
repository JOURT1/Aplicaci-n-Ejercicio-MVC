using Microsoft.EntityFrameworkCore;
using MiniCoreComisiones.Models; // Asegúrate de que el namespace sea el correcto

namespace MiniCoreComisiones.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<ReglaComision> ReglasComision { get; set; }
    }
}