using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class ClientMeasurement : IClientMeasurement
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Measurement { get; set; }

        [Required]
        public DateTimeOffset Date_Measurement { get; set; }

        [Required]
        public string Location_Measurement { get; set; } = string.Empty;

        // Propiedades con sufijo _Measurement para evitar conflictos
        [Required]
        public double IsoThreshold_Measurement { get; set; }

        [Required]
        public string MeasurementMethod_Measurement { get; set; } = string.Empty;

        [Required]
        public string MeasuredRange_Measurement { get; set; } = string.Empty;

        [Required]
        public string Probability_Measurement { get; set; } = string.Empty;

        [Required]
        public decimal Value_Measurement { get; set; }

        public string? Notes_Measurement { get; set; }
    }

    public interface IMeasurementSubstanceData
    {
        int Id_Measurement { get; set; }
        string SubstanceName_Measurement { get; set; }
        double IsoThreshold_Measurement { get; set; }
        string MeasurementMethod_Measurement { get; set; }
        string MeasuredRange_Measurement { get; set; }
        string Probability_Measurement { get; set; }
    }

    public class WaterMeasurement : IMeasurementSubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Measurement { get; set; }
        public string SubstanceName_Measurement { get; set; } = string.Empty;
        public double IsoThreshold_Measurement { get; set; }
        public string MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Probability_Measurement { get; set; } = string.Empty;
    }

    public class NonCH4HydrocarbonsMeasurement : IMeasurementSubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Measurement { get; set; }
        public string SubstanceName_Measurement { get; set; } = string.Empty;
        public double IsoThreshold_Measurement { get; set; }
        public string MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Probability_Measurement { get; set; } = string.Empty;
    }

    public class OxygenMeasurement : IMeasurementSubstanceData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_Measurement { get; set; }
        public string SubstanceName_Measurement { get; set; } = string.Empty;
        public double IsoThreshold_Measurement { get; set; }
        public string MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Probability_Measurement { get; set; } = string.Empty;
    }

    public class HeliumMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class NitrogenMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class ArgonMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class CarbonDioxideMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class CarbonMonoxidMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class SulphurCompoundsMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class FormaldehydeMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class FormicAcidMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class AmmoniaMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class HalogenatedCompoundsMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}

public class HydrocarbonsMeasurement : IMeasurementSubstanceData
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id_Measurement { get; set; }
    public string SubstanceName_Measurement { get; set; } = string.Empty;
    public double IsoThreshold_Measurement { get; set; }
    public string MeasurementMethod_Measurement { get; set; } = string.Empty;
    public string MeasuredRange_Measurement { get; set; } = string.Empty;
    public string Probability_Measurement { get; set; } = string.Empty;
}
}