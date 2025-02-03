using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class Water : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 5;
        public string Probability { get; set; } = "Rare (2)";
    }

    public class Methane : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class NonCH4Hydrocarbons : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Oxygen : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 5;
        public string Probability { get; set; } = "Rare (2)";
    }

    public class Helium : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 300;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Nitrogen : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 100;
        public string Probability { get; set; } = "Rare (2)";
    }

    public class Argon : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 100;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class CarbonDioxide : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public string Probability { get; set; } = "Very rare (1)";
    }

    public class CarbonMonoxide : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.2;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class SulphurCompounds : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.004;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Formaldehyde : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.01;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class FormicAcid : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.2;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Ammonia : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.1;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class HalogenatedCompounds : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.05;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Hydrocarbons : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public string Probability { get; set; } = "Unlikely (0)";
    }
}