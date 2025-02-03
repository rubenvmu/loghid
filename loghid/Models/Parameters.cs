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
        public double PemResult { get; set; } = 3;
        public string Probability { get; set; } = "Rare (2)";
    }

    public class Methane : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public double PemResult { get; set; } = 0.02;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class NonCH4Hydrocarbons : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public double PemResultMin { get; set; } = 0.08;
        public double PemResultMax { get; set; } = 0.2;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Oxygen : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 5;
        public double PemResultMin { get; set; } = 0.5;
        public double PemResultMax { get; set; } = 2;
        public string Probability { get; set; } = "Rare (2)";
    }

    public class Helium : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 300;
        public double PemResultMin { get; set; } = 9;
        public double PemResultMax { get; set; } = 45;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Nitrogen : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 100;
        public double PemResultMin { get; set; } = 1.0;
        public double PemResultMax { get; set; } = 4.6;
        public string Probability { get; set; } = "Rare (2)";
    }

    public class Argon : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 100;
        public double PemResult { get; set; } = 0.5;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class CarbonDioxide : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public double PemResultMin { get; set; } = 0.02;
        public double PemResultMax { get; set; } = 0.25;
        public string Probability { get; set; } = "Very rare (1)";
    }

    public class CarbonMonoxide : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.2;
        public double PemResult { get; set; } = 0.02;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class SulphurCompounds : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.004;
        public double PemResult { get; set; } = 0.0036;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Formaldehyde : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.01;
        public double PemResult { get; set; } = 0.005;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class FormicAcid : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.2;
        public double PemResult { get; set; } = 0.1;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Ammonia : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.1;
        public double PemResult { get; set; } = 0.1;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class HalogenatedCompounds : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 0.05;
        public double PemResult { get; set; } = 0.005;
        public string Probability { get; set; } = "Unlikely (0)";
    }

    public class Hydrocarbons : ISubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public double IsoThreshold { get; set; } = 2;
        public double PemResultC2 { get; set; } = 0.5;
        public double PemResultC3 { get; set; } = 1;
        public double PemResultC4 { get; set; } = 1;
        public double PemResultC5 { get; set; } = 1;
        public double PemResultC6C18 { get; set; } = 0.05;
        public string Probability { get; set; } = "Unlikely (0)";
    }
}