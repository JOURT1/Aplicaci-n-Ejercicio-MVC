using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniCoreComisiones.Models
{
    public class Venta
    {
        public int VentaId { get; set; }

        [Required]
        public int VendedorId { get; set; }

        [ForeignKey("VendedorId")]
        public Vendedor Vendedor { get; set; }

        [Required]
        public DateTime FechaVenta { get; set; }

        [Required]
        public decimal Monto { get; set; }
    }
}
