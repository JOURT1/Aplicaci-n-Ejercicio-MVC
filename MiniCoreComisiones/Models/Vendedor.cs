using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MiniCoreComisiones.Models
{
    public class Vendedor
    {
        public int VendedorId { get; set; }

        [Required]
        public string Nombre { get; set; } = string.Empty; // <- evita warning de null

        public ICollection<Venta> Ventas { get; set; }
    }
}
