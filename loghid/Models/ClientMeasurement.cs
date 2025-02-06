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

        [DatabaseGenerated(DatabaseGeneratedOption.None)] // No permitir que la BD lo genere
    public string? PublicID_Measurement { get; set; }

    public ClientMeasurement()
    {
        PublicID_Measurement = GenerateUniquePublicId();
    }

    private static string GenerateUniquePublicId()
    {
        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        Random random = new Random();
        var id = new string(Enumerable.Repeat(chars, 16)
                            .Select(s => s[random.Next(s.Length)]).ToArray());

        return $"{id.Substring(0, 4)}-{id.Substring(4, 4)}-{id.Substring(8, 4)}-{id.Substring(12, 4)}";
    }

        [Required]
        public DateTimeOffset Date_Measurement { get; set; }


        [Required]
        public int CustomerID_Measurement { get; set; }
        [Required]
        public string Customer_Measurement { get; set; } = string.Empty;

        [Required]
        public int SupplierID_Measurement { get; set; }

        [Required]
        public string Supplier_Measurement { get; set; } = string.Empty;

        [Required]
        public string Location_Measurement { get; set; } = string.Empty;


        public string? Notes_Measurement { get; set; }
        public string Water_Name_Measurement { get; set; } = string.Empty;
        public string Water_ISO_Threshold_Measurement { get; set; } = string.Empty;
        public string Water_Measurement_Method_Measurement { get; set; } = string.Empty;
        public string Water_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Water_Probability_Measurement { get; set; } = string.Empty;

        public string Methane_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Methane_IsoThreshold_Measurement { get; set; }
        public string Methane_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Methane_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Methane_Probability_Measurement { get; set; } = string.Empty;

        public string NonCH4Hydrocarbons_SubstanceName_Measurement { get; set; } = string.Empty;
        public double NonCH4Hydrocarbons_IsoThreshold_Measurement { get; set; }
        public string NonCH4Hydrocarbons_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string NonCH4Hydrocarbons_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string NonCH4Hydrocarbons_Probability_Measurement { get; set; } = string.Empty;

        public string Oxygen_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Oxygen_IsoThreshold_Measurement { get; set; }
        public string Oxygen_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Oxygen_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Oxygen_Probability_Measurement { get; set; } = string.Empty;

        public string Helium_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Helium_IsoThreshold_Measurement { get; set; }
        public string Helium_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Helium_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Helium_Probability_Measurement { get; set; } = string.Empty;

        public string Nitrogen_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Nitrogen_IsoThreshold_Measurement { get; set; }
        public string Nitrogen_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Nitrogen_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Nitrogen_Probability_Measurement { get; set; } = string.Empty;

        public string Argon_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Argon_IsoThreshold_Measurement { get; set; }
        public string Argon_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Argon_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Argon_Probability_Measurement { get; set; } = string.Empty;

        public string CarbonDioxide_SubstanceName_Measurement { get; set; } = string.Empty;
        public double CarbonDioxide_Argon_IsoThreshold_Measurement { get; set; }
        public string CarbonDioxide_Argon_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string CarbonDioxide_Argon_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string CarbonDioxide_Argon_Probability_Measurement { get; set; } = string.Empty;

        public string CarbonMonoxid_SubstanceName_Measurement { get; set; } = string.Empty;
        public double CarbonMonoxid_IsoThreshold_Measurement { get; set; }
        public string CarbonMonoxid_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string CarbonMonoxid_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string CarbonMonoxid_Probability_Measurement { get; set; } = string.Empty;

        public string SulphurCompounds_SubstanceName_Measurement { get; set; } = string.Empty;
        public double SulphurCompounds_IsoThreshold_Measurement { get; set; }
        public string SulphurCompounds_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string SulphurCompounds_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string SulphurCompounds_Probability_Measurement { get; set; } = string.Empty;

        public string Formaldehyde_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Formaldehyde_IsoThreshold_Measurement { get; set; }
        public string Formaldehyde_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Formaldehyde_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Formaldehyde_Probability_Measurement { get; set; } = string.Empty;

        public string FormicAcid_SubstanceName_Measurement { get; set; } = string.Empty;
        public double FormicAcid_IsoThreshold_Measurement { get; set; }
        public string FormicAcid_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string FormicAcid_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string FormicAcid_Probability_Measurement { get; set; } = string.Empty;

        public string Amonia_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Amonia_IsoThreshold_Measurement { get; set; }
        public string Amonia_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Amonia_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Amonia_Probability_Measurement { get; set; } = string.Empty;

        public string HalogenatedCompounds_SubstanceName_Measurement { get; set; } = string.Empty;
        public double HalogenatedCompounds_IsoThreshold_Measurement { get; set; }
        public string HalogenatedCompounds_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string HalogenatedCompounds_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string HalogenatedCompounds_Probability_Measurement { get; set; } = string.Empty;

        public string Hydrocarbons_SubstanceName_Measurement { get; set; } = string.Empty;
        public double Hydrocarbons_IsoThreshold_Measurement { get; set; }
        public string Hydrocarbons_MeasurementMethod_Measurement { get; set; } = string.Empty;
        public string Hydrocarbons_MeasuredRange_Measurement { get; set; } = string.Empty;
        public string Hydrocarbons_Probability_Measurement { get; set; } = string.Empty;
        public string Method_Measurement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Range_Measurement { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
}