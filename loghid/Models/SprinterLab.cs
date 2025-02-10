using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class SprinterLab : ISprinterLab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Vehicle { get; set; } = "Mercedes-Benz Sprinter";

        [Range(0, double.MaxValue)]
        public decimal VehiclePrice { get; set; }

        [Range(0, double.MaxValue)]
        public double LoadCapacity { get; set; } = 3500;


        [Range(0, double.MaxValue)]
        public double InteriorSpace { get; set; } = 14.0;

        [Range(0, double.MaxValue)]
        public decimal InteriorSpacePrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string Chromatograph { get; set; } = "Shimadzu Nexis GC-2030";

        [Range(0, double.MaxValue)]
        public decimal ChromatographPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string HydrogenStandard { get; set; } = "ISO 19880-8";

        [Range(0, double.MaxValue)]
        public decimal HydrogenStandardPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string PurityStandard { get; set; } = "ISO 14687:2006";

        [Range(0, double.MaxValue)]
        public decimal PurityStandardPrice { get; set; }

        [Range(0, 100)]
        public double MinimumPurity { get; set; } = 98.0;

        [Range(0, double.MaxValue)]
        public decimal MinimumPurityPrice { get; set; }

        [Range(0, 100)]
        public double OptimalPurity { get; set; } = 99.995;

        [Range(0, double.MaxValue)]
        public decimal OptimalPurityPrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string HydrogenDetector { get; set; } = "TCD - Thermal Conductivity Detector";

        [Range(0, double.MaxValue)]
        public decimal HydrogenDetectorPrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string HydrocarbonDetector { get; set; } = "FID - Flame Ionization Detector";

        [Range(0, double.MaxValue)]
        public decimal HydrocarbonDetectorPrice { get; set; }

        [Required]
        [MaxLength(150)]
        public string OxygenOthersDetector { get; set; } = "GC with 0.5 µmol/mol or 20% sensitivity";

        [Range(0, double.MaxValue)]
        public decimal OxygenOthersDetectorPrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string SulfurDetector { get; set; } = "FPD - Flame Photometric Detector";

        [Range(0, double.MaxValue)]
        public decimal SulfurDetectorPrice { get; set; }

        [Range(0, int.MaxValue)]
        public int MinimumMicronFilter { get; set; } = 10;

        [Range(0, double.MaxValue)]
        public decimal MinimumMicronFilterPrice { get; set; }

        [Range(0, int.MaxValue)]
        public int MaximumMicronFilter { get; set; } = 40;

        [Range(0, double.MaxValue)]
        public decimal MaximumMicronFilterPrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string SampleCollectionMethod { get; set; } = "Bottle from a representative batch";

        [Range(0, double.MaxValue)]
        public decimal SampleCollectionMethodPrice { get; set; }

        [Required]
        [MaxLength(20)]
        public string MolarFractionUnit { get; set; } = "%";

        [Range(0, double.MaxValue)]
        public decimal MolarFractionUnitPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string WaterContentUnit { get; set; } = "cm3/m3 (electrolytic hygrometer)";

        [Range(0, double.MaxValue)]
        public decimal WaterContentUnitPrice { get; set; }

        [Required]
        [MaxLength(20)]
        public string ImpuritiesUnit { get; set; } = "µmol/mol";

        [Range(0, double.MaxValue)]
        public decimal ImpuritiesUnitPrice { get; set; }

        [Required]
        [MaxLength(150)]
        public string CalibrationMethod { get; set; } = "Calibration standard gas with analyte";

        [Range(0, double.MaxValue)]
        public decimal CalibrationMethodPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string CalibrationStandard { get; set; } = "ISO 21087";

        [Range(0, double.MaxValue)]
        public decimal CalibrationStandardPrice { get; set; }

        public bool PressureTest { get; set; } = true;

        [Range(0, double.MaxValue)]
        public decimal PressureTestPrice { get; set; }

        public bool LeakTest { get; set; } = true;

        [Range(0, double.MaxValue)]
        public decimal LeakTestPrice { get; set; }

        public bool HydrogenQualityTest { get; set; } = true;

        [Range(0, double.MaxValue)]
        public decimal HydrogenQualityTestPrice { get; set; }

        [Required]
        [MaxLength(50)]
        public string CarrierGas { get; set; } = "He (Helium)";

        [Range(0, double.MaxValue)]
        public decimal CarrierGasPrice { get; set; }

        [Required]
        [MaxLength(100)]
        public string AlternativeCarrier { get; set; } = "N2 (requires more analysis time)";

        [Range(0, double.MaxValue)]
        public decimal AlternativeCarrierPrice { get; set; }

        [Range(0, double.MaxValue)]
        public double MinimumSensitivity { get; set; } = 0.1;

        [Range(0, double.MaxValue)]
        public decimal MinimumSensitivityPrice { get; set; }

        public bool VibrationIsolationSystem { get; set; } = true;

        [Range(0, double.MaxValue)]
        public decimal VibrationIsolationSystemPrice { get; set; }

        public bool ControlledClimateSystem { get; set; } = true;

        [Range(0, double.MaxValue)]
        public decimal ControlledClimateSystemPrice { get; set; }

        public bool IndependentPowerSystem { get; set; } = true;

        [Range(0, double.MaxValue)]
        public decimal IndependentPowerSystemPrice { get; set; }
    }
}