using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class eSprinterLab : IeSprinterLab
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Vehicle { get; set; } = "Mercedes-Benz Sprinter";

        [Range(0, double.MaxValue)]
        public double VehiclePrice { get; set; }

        [Display(Name = "Cargo Capacity (kg)")]
        [Range(0, double.MaxValue)]
        public double CargoCapacity { get; set; } = 2854.0;

        [Display(Name = "Interior Space (m³)")]
        [Range(0, double.MaxValue)]
        public double InteriorSpace { get; set; } = 14.0;

        [Display(Name = "Autonomy Capacity")]
        [Range(0, double.MaxValue)]
        public double AutonomyCapacity { get; set; }

        [Display(Name = "Price per 100km")]
        [Range(0, double.MaxValue)]
        public double PricePer100km { get; set; }

        // Chromatography Equipment
        [Range(0, double.MaxValue)]
        public double Chromatograph { get; set; } = 65000.0;

        [Range(0, double.MaxValue)]
        public double TCD { get; set; } = 8000.0;

        [Range(0, double.MaxValue)]
        public double FID { get; set; } = 1400.0;

        [Range(0, double.MaxValue)]
        public double Hygrometer { get; set; } = 1500.0;

        [Range(0, double.MaxValue)]
        public double FPD { get; set; } = 3350.0;

        // Gas System
        [Range(0, double.MaxValue)]
        public double PressureRegulators { get; set; } = 2000.0;

        [Range(0, double.MaxValue)]
        public double StandardGasBottles { get; set; } = 2550.0;

        [Range(0, double.MaxValue)]
        public double GasColumns { get; set; } = 3000.0;

        [Range(0, double.MaxValue)]
        public double HeliumCarrierGas { get; set; } = 200.0;

        [Range(0, double.MaxValue)]
        public double AirFuelGas { get; set; } = 150.0;

        // Certifications & Services
        [Range(0, double.MaxValue)]
        public double ChromatographCertification { get; set; } = 3000.0;

        [Range(0, double.MaxValue)]
        public double RegulatoryConsultations { get; set; } = 1000.0;

        [Range(0, double.MaxValue)]
        public double AnalysisService { get; set; } = 640.0;

        [Range(0, double.MaxValue)]
        public double Calibration { get; set; } = 300.0;

        [Range(0, double.MaxValue)]
        public double VehicleMaintenance { get; set; } = 20.0;

        [Display(Name = "Total Price (€)")]
        public double TotalPrice { get; set; } = 0.0;
    }
}