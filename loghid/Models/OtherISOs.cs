using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public abstract class ISOStandard
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(60)]
        public string DisplayName { get; set; } = "ISO Standard";
        
        [Required]
        [MaxLength(30)]
        public string StandardCode { get; set; } = "ISO XXXXX:YYYY";
        
        public int Year { get; set; }
        
        [MaxLength(200)]
        public string Description { get; set; } = "Description of the ISO standard";
    }

    public class ISO21087 : ISOStandard
    {
        [Required]
        [MaxLength(100)]
        public string AnalysisMethod { get; set; }
        
        [Required]
        public double ImpurityDetectionLimit { get; set; }

        public ISO21087()
        {
            StandardCode = "ISO 21087:2019";
            DisplayName = "Analysis Methods for Gaseous Hydrogen Quality";
            Year = 2019;
            Description = "Defines analytical methods to determine critical impurities in gaseous hydrogen for traceability and certification.";
            AnalysisMethod = "Gas Chromatography";
            ImpurityDetectionLimit = 1.0;
        }
    }

    public class ISO14067 : ISOStandard
    {
        [Required]
        [MaxLength(100)]
        public string LifeCycleAssessmentMethod { get; set; }
        
        [Required]
        public double CarbonFootprint { get; set; }

        public ISO14067()
        {
            StandardCode = "ISO 14067:2018";
            DisplayName = "Carbon Footprint of Products";
            Year = 2018;
            Description = "Provides guidelines for quantifying the carbon footprint of products, including the environmental impact of green hydrogen.";
            LifeCycleAssessmentMethod = "Cradle-to-Grave LCA";
            CarbonFootprint = 10.0;
        }
    }

    public class ISO19880_1 : ISOStandard
    {
        [Required]
        [MaxLength(200)]
        public string SafetyRequirements { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string PerformanceMetrics { get; set; }

        public ISO19880_1()
        {
            StandardCode = "ISO 19880-1:2020";
            DisplayName = "Gaseous Hydrogen – Fuelling Stations – Part 1: General Requirements";
            Year = 2020;
            Description = "Specifies general safety and performance requirements for fuelling stations dispensing gaseous hydrogen.";
            SafetyRequirements = "Minimum safety distances, proper ventilation, emergency shutdown systems";
            PerformanceMetrics = "Pressure: 350-700 bar, Flow rate: up to 2 kg/min";
        }
    }

    public class ISOTR15916 : ISOStandard
    {
        [Required]
        [MaxLength(150)]
        public string RiskAssessmentMethod { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string SafetyMeasures { get; set; }

        public ISOTR15916()
        {
            StandardCode = "ISO/TR 15916:2015";
            DisplayName = "Safety in the Use of Hydrogen";
            Year = 2015;
            Description = "Provides guidelines and recommendations for the safe use of hydrogen, including risk assessment and safety measures.";
            RiskAssessmentMethod = "HAZOP analysis";
            SafetyMeasures = "Emergency shutdown systems, leak detection, proper venting";
        }
    }

    public class ISO26142 : ISOStandard
    {
        [Required]
        [MaxLength(100)]
        public string SensorType { get; set; }
        
        [Required]
        public double DetectionRange { get; set; }
        
        [Required]
        public double ResponseTime { get; set; }

        public ISO26142()
        {
            StandardCode = "ISO 26142:2010";
            DisplayName = "Hydrogen Detection Sensors";
            Year = 2010;
            Description = "Specifies requirements for hydrogen detection sensors used in safety systems.";
            SensorType = "Electrochemical sensor";
            DetectionRange = 10.0;
            ResponseTime = 10.0;
        }
    }

    public class ISOC23985 : ISOStandard
    {
        [Required]
        [MaxLength(200)]
        public string SustainabilityCriteria { get; set; }
        
        [Required]
        public bool ProductionProcessVerified { get; set; }

        public ISOC23985()
        {
            StandardCode = "ISO/CD 23985";
            DisplayName = "Hydrogen Production Certification";
            Year = 2020;
            Description = "Outlines the certification process for sustainable hydrogen production under strict environmental standards.";
            SustainabilityCriteria = "Renewable energy share ≥ 80%, CO2 reduction > 90%";
            ProductionProcessVerified = true;
        }
    }

    public class ISO14040_14044 : ISOStandard
    {
        [Required]
        [MaxLength(150)]
        public string LCAMethodology { get; set; }
        
        [Required]
        [MaxLength(150)]
        public string EnvironmentalImpactMetrics { get; set; }

        public ISO14040_14044()
        {
            StandardCode = "ISO 14040/14044:2006";
            DisplayName = "Life Cycle Assessment for Environmental Impact";
            Year = 2006;
            Description = "Provides the framework and guidelines for conducting a Life Cycle Assessment (LCA) to evaluate the environmental impacts of products, including green hydrogen.";
            LCAMethodology = "Cradle-to-Grave LCA";
            EnvironmentalImpactMetrics = "Global Warming Potential (GWP), Acidification Potential (AP)";
        }
    }

    public class ISO23306 : ISOStandard
    {
        [Required]
        [MaxLength(150)]
        public string CertificationMethodology { get; set; }
        
        [Required]
        public double CarbonIntensityThreshold { get; set; }

        public ISO23306()
        {
            StandardCode = "ISO 23306:2020";
            DisplayName = "Certification for Renewable & Low-Carbon Hydrogen";
            Year = 2020;
            Description = "Defines methodologies for certifying renewable and low-carbon hydrogen, ensuring its production meets sustainability targets.";
            CertificationMethodology = "Third-party audit and self-declaration protocols";
            CarbonIntensityThreshold = 10.0;
        }
    }
}
