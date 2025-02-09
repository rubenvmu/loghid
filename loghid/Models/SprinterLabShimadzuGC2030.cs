using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Loghid.Interfaces;

namespace Loghid.Models
{

    public class SprinterLabShimadzuGC2030 : ISprinterLabShimadzuGC2030
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Vehicle { get; set; } = "Mercedes-Benz Sprinter";
        public string ConversionType { get; set; } = "Mobile laboratory for hydrogen analysis";
        public double LoadCapacity { get; set; } = 3500;
        public double InteriorSpace { get; set; } = 14.0;

        public string EquipmentModel { get; set; } = "Shimadzu Nexis GC-2030";
        public string HydrogenStandard { get; set; } = "ISO 19880-8";
        public string PurityStandard { get; set; } = "ISO 14687:2006";
        public double MinimumPurity { get; set; } = 98.0;
        public double OptimalPurity { get; set; } = 99.995;

        public string HydrogenDetector { get; set; } = "TCD - Thermal Conductivity Detector";
        public string HydrocarbonDetector { get; set; } = "FID - Flame Ionization Detector";
        public string OxygenOthersDetector { get; set; } = "GC with 0.5 µmol/mol or 20% sensitivity";
        public string SulfurDetector { get; set; } = "FPD - Flame Photometric Detector";

        public int MinimumMicronFilter { get; set; } = 10;
        public int MaximumMicronFilter { get; set; } = 40;

        public string SampleCollectionMethod { get; set; } = "Bottle from a representative batch";

        public string MolarFractionUnit { get; set; } = "%";
        public string WaterContentUnit { get; set; } = "cm3/m3 (electrolytic hygrometer)";
        public string ImpuritiesUnit { get; set; } = "µmol/mol";

        public string CalibrationMethod { get; set; } = "Calibration standard gas with analyte";
        public string CalibrationStandard { get; set; } = "ISO 21087";

        public bool PressureTest { get; set; } = true;
        public bool LeakTest { get; set; } = true;
        public bool HydrogenQualityTest { get; set; } = true;

        public string CarrierGas { get; set; } = "He (Helium)";
        public string AlternativeCarrier { get; set; } = "N2 (requires more analysis time)";

        public double MinimumSensitivity { get; set; } = 0.1;

        public bool VibrationIsolationSystem { get; set; } = true;
        public bool ControlledClimateSystem { get; set; } = true;
        public bool IndependentPowerSystem { get; set; } = true;

        public SprinterLabShimadzuGC2030()
        {
        }
    }
}