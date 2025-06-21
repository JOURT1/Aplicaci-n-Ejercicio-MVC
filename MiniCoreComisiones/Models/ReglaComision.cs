using System.ComponentModel.DataAnnotations;

public class ReglaComision
{
    public int ReglaComisionId { get; set; }

    [Required]
    public decimal MinMonto { get; set; }

    [Required]
    public decimal MaxMonto { get; set; }

    [Required]
    public decimal PorcentajeComision { get; set; }
}
