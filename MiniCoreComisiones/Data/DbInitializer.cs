using MiniCoreComisiones.Models;

namespace MiniCoreComisiones.Data
{
    public static class DbInitializer
    {
        public static void Inicializar(AppDbContext context)
        {
            // Si ya hay vendedores, no cargues datos de nuevo
            if (context.Vendedores.Any()) return;

            // Vendedores de ejemplo
            var vendedores = new Vendedor[]
            {
                new Vendedor { Nombre = "Carlos Pérez" },
                new Vendedor { Nombre = "Andrea López" },
                new Vendedor { Nombre = "Jorge Molina" }
            };
            context.Vendedores.AddRange(vendedores);
            context.SaveChanges();

            // Ventas de ejemplo
            var ventas = new Venta[]
            {
                new Venta { VendedorId = 1, FechaVenta = DateTime.Parse("2024-06-01"), Monto = 100 },
                new Venta { VendedorId = 1, FechaVenta = DateTime.Parse("2024-06-15"), Monto = 250 },
                new Venta { VendedorId = 2, FechaVenta = DateTime.Parse("2024-06-10"), Monto = 300 },
                new Venta { VendedorId = 3, FechaVenta = DateTime.Parse("2024-06-20"), Monto = 150 }
            };
            context.Ventas.AddRange(ventas);
            context.SaveChanges();

            // Reglas de comisión
            var reglas = new ReglaComision[]
            {
                new ReglaComision { MinMonto = 0, MaxMonto = 200, PorcentajeComision = 5 },
                new ReglaComision { MinMonto = 201, MaxMonto = 500, PorcentajeComision = 10 },
                new ReglaComision { MinMonto = 501, MaxMonto = 1000, PorcentajeComision = 15 }
            };
            context.ReglasComision.AddRange(reglas);
            context.SaveChanges();
        }
    }
}
