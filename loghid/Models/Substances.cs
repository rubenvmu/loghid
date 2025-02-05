using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class Substance : ISubstanceData
{

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public required int Id { get; set; } 
        public required string SubstanceName { get; set; }
        public required double IsoThreshold { get; set; }
        public required string MeasurementMethod { get; set; }
        public required string MeasuredRange { get; set; }
        public required string Probability { get; set; }
}

    // También puedes tener una enumeración para los tipos de sustancia
    public enum SubstanceTypes
    {
        Water,
        Methane,
        NonCH4Hydrocarbons,
        Oxygen,
        Helium,
        Nitrogen,
        Argon,
        CarbonDioxide,
        CarbonMonoxide,
        SulphurCompounds,
        Formaldehyde,
        FormicAcid,
        Ammonia,
        HalogenatedCompounds,
        Hydrocarbons
    }
}