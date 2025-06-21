using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiniCoreComisiones.Data;
using MiniCoreComisiones.Models;

namespace MiniCoreComisiones.Controllers
{
    public class ComisionesController : Controller
    {
        private readonly AppDbContext _context;

        public ComisionesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? vendedorId, DateTime? fechaInicio, DateTime? fechaFin)
        {
            ViewBag.Vendedores = await _context.Vendedores.ToListAsync();

            var ventas = new List<Venta>();
            decimal totalVentas = 0;
            decimal comisionFinal = 0;
            decimal? porcentaje = null;

            if (vendedorId.HasValue && fechaInicio.HasValue && fechaFin.HasValue)
            {
                ventas = await _context.Ventas
                    .Include(v => v.Vendedor)
                    .Where(v => v.VendedorId == vendedorId &&
                                v.FechaVenta >= fechaInicio &&
                                v.FechaVenta <= fechaFin)
                    .ToListAsync();

                totalVentas = ventas.Sum(v => v.Monto);

                var regla = await _context.ReglasComision
                    .FirstOrDefaultAsync(r => totalVentas >= r.MinMonto && totalVentas <= r.MaxMonto);

                if (regla != null)
                {
                    porcentaje = regla.PorcentajeComision;
                    comisionFinal = totalVentas * (porcentaje.Value / 100);
                }

                var vendedor = await _context.Vendedores.FindAsync(vendedorId);
                ViewBag.NombreVendedor = vendedor?.Nombre;
                ViewBag.ReglaPorcentaje = porcentaje;
                ViewBag.TotalVentas = totalVentas;
                ViewBag.Comision = comisionFinal;
            }

            // Obtener fechas mínimas y máximas del total de ventas para sugerir
            var todasLasFechas = await _context.Ventas.Select(v => v.FechaVenta).ToListAsync();
            if (todasLasFechas.Any())
            {
                ViewBag.FechaMin = todasLasFechas.Min().ToString("dd/MM/yyyy");
                ViewBag.FechaMax = todasLasFechas.Max().ToString("dd/MM/yyyy");
            }

            return View(ventas);
        }
    }
}
