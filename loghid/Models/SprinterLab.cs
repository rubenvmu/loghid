using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class SprinterLab : ISprinterLab
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Vehicle { get; set; } = "Mercedes-Benz Sprinter";
        public decimal VehiclePrice { get; set; }

        public string ConversionType { get; set; } = "Mobile laboratory for hydrogen analysis";
        public decimal ConversionTypePrice { get; set; }

        public double LoadCapacity { get; set; } = 3500;
        public decimal LoadCapacityPrice { get; set; }

        public double InteriorSpace { get; set; } = 14.0;
        public decimal InteriorSpacePrice { get; set; }

        public string EquipmentModel { get; set; } = "Shimadzu Nexis GC-2030";
        public decimal EquipmentModelPrice { get; set; }

        public string HydrogenStandard { get; set; } = "ISO 19880-8";
        public decimal HydrogenStandardPrice { get; set; }

        public string PurityStandard { get; set; } = "ISO 14687:2006";
        public decimal PurityStandardPrice { get; set; }

        public double MinimumPurity { get; set; } = 98.0;
        public decimal MinimumPurityPrice { get; set; }

        public double OptimalPurity { get; set; } = 99.995;
        public decimal OptimalPurityPrice { get; set; }

        public string HydrogenDetector { get; set; } = "TCD - Thermal Conductivity Detector";
        public decimal HydrogenDetectorPrice { get; set; }

        public string HydrocarbonDetector { get; set; } = "FID - Flame Ionization Detector";
        public decimal HydrocarbonDetectorPrice { get; set; }

        public string OxygenOthersDetector { get; set; } = "GC with 0.5 µmol/mol or 20% sensitivity";
        public decimal OxygenOthersDetectorPrice { get; set; }

        public string SulfurDetector { get; set; } = "FPD - Flame Photometric Detector";
        public decimal SulfurDetectorPrice { get; set; }

        public int MinimumMicronFilter { get; set; } = 10;
        public decimal MinimumMicronFilterPrice { get; set; }

        public int MaximumMicronFilter { get; set; } = 40;
        public decimal MaximumMicronFilterPrice { get; set; }

        public string SampleCollectionMethod { get; set; } = "Bottle from a representative batch";
        public decimal SampleCollectionMethodPrice { get; set; }

        public string MolarFractionUnit { get; set; } = "%";
        public decimal MolarFractionUnitPrice { get; set; }

        public string WaterContentUnit { get; set; } = "cm3/m3 (electrolytic hygrometer)";
        public decimal WaterContentUnitPrice { get; set; }

        public string ImpuritiesUnit { get; set; } = "µmol/mol";
        public decimal ImpuritiesUnitPrice { get; set; }

        public string CalibrationMethod { get; set; } = "Calibration standard gas with analyte";
        public decimal CalibrationMethodPrice { get; set; }

        public string CalibrationStandard { get; set; } = "ISO 21087";
        public decimal CalibrationStandardPrice { get; set; }

        public bool PressureTest { get; set; } = true;
        public decimal PressureTestPrice { get; set; }

        public bool LeakTest { get; set; } = true;
        public decimal LeakTestPrice { get; set; }

        public bool HydrogenQualityTest { get; set; } = true;
        public decimal HydrogenQualityTestPrice { get; set; }

        public string CarrierGas { get; set; } = "He (Helium)";
        public decimal CarrierGasPrice { get; set; }

        public string AlternativeCarrier { get; set; } = "N2 (requires more analysis time)";
        public decimal AlternativeCarrierPrice { get; set; }

        public double MinimumSensitivity { get; set; } = 0.1;
        public decimal MinimumSensitivityPrice { get; set; }

        public bool VibrationIsolationSystem { get; set; } = true;
        public decimal VibrationIsolationSystemPrice { get; set; }

        public bool ControlledClimateSystem { get; set; } = true;
        public decimal ControlledClimateSystemPrice { get; set; }

        public bool IndependentPowerSystem { get; set; } = true;
        public decimal IndependentPowerSystemPrice { get; set; }
    }
}