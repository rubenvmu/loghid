using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class Water : ISubstanceData
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
    

    public class Methane : ISubstanceData
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

    public class NonCH4Hydrocarbons : ISubstanceData
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

    public class Oxygen : ISubstanceData
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

    public class Helium : ISubstanceData
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

    public class Nitrogen : ISubstanceData
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

    public class Argon : ISubstanceData
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

    public class CarbonDioxide : ISubstanceData
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

    public class CarbonMonoxide : ISubstanceData
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

    public class SulphurCompounds : ISubstanceData
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

    public class Formaldehyde : ISubstanceData
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

    public class FormicAcid : ISubstanceData
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

    public class Ammonia : ISubstanceData
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

    public class HalogenatedCompounds : ISubstanceData
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

    public class Hydrocarbons : ISubstanceData
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
}