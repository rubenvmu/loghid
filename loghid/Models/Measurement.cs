using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class Measurement : IClientMeasurement
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    public DateTimeOffset MeasurementDate { get; set; }

    [Required]
    public string Location { get; set; } = string.Empty; // Asegura que Location no sea nulo

    [Required]
    public int SubstanceId { get; set; }

    [ForeignKey("SubstanceId")]
    public virtual Substance Substance { get; set; } = new Substance
    {
        // Inicializar las propiedades requeridas de Substance aquí
        Id = 0, // Asigna un valor predeterminado apropiado o usa un valor real
        SubstanceName = string.Empty,
        IsoThreshold = 0.0,  // Asignar un valor adecuado
        MeasurementMethod = string.Empty,
        MeasuredRange = string.Empty,
        Probability = string.Empty
    };

    [Required]
    public double IsoThreshold { get; set; }

    [Required]
    public string MeasurementMethod { get; set; } = string.Empty; // Asegura que MeasurementMethod no sea nulo

    [Required]
    public string MeasuredRange { get; set; } = string.Empty; // Asegura que MeasuredRange no sea nulo

    [Required]
    public string Probability { get; set; } = string.Empty; // Asegura que Probability no sea nulo

    // Implementación de la propiedad SubstanceName
    [Required]
    public string SubstanceName
    {
        get { return Substance?.SubstanceName ?? string.Empty; }
        set { }
    }

    // Implementación de la propiedad Value (de la interfaz IClientMeasurement)
    [Required]
    public decimal Value { get; set; }

    // Implementación de la propiedad Notes (de la interfaz IClientMeasurement)
    public string? Notes { get; set; }
}


}
