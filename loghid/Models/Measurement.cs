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
    public double IsoThreshold { get; set; }

    [Required]
    public string MeasurementMethod { get; set; } = string.Empty; // Asegura que MeasurementMethod no sea nulo

    [Required]
    public string MeasuredRange { get; set; } = string.Empty; // Asegura que MeasuredRange no sea nulo

    [Required]
    public string Probability { get; set; } = string.Empty; // Asegura que Probability no sea nulo

    // Implementación de la propiedad SubstanceNam

    // Implementación de la propiedad Value (de la interfaz IClientMeasurement)
    [Required]
    public decimal Value { get; set; }

    // Implementación de la propiedad Notes (de la interfaz IClientMeasurement)
    public string? Notes { get; set; }
}


}
