using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iText.Kernel.Pdf;
using iText.Layout;
using System.Security.Cryptography;
using System.Text;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using Loghid.Data;
using Loghid.Models;

namespace Loghid.Pages
{
    public class CertificatesIndex : PageModel
    {
        private readonly LoghidClientMeasurementDbContext _context;
        public IList<ClientMeasurement> ClientMeasurement { get; set; } = new List<ClientMeasurement>();

        public CertificatesIndex(LoghidClientMeasurementDbContext context)
        {
            _context = context;
        }

        private string CalculateSHA256Hash(string content)
{
    using (SHA256 sha256 = SHA256.Create())
    {
        byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(content));
        return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
    }
}

        public async Task OnGetAsync()
        {
            ClientMeasurement = await _context.Measurements.ToListAsync();
        }

        public async Task<IActionResult> OnGetDownloadAsync(int id)
{
    var measurement = await _context.Measurements.FindAsync(id);
    if (measurement == null)
    {
        Console.WriteLine("Measurement not found.");
        return NotFound();
    }

    string sanitizedPublicId = Regex.Replace(
        measurement.PublicID_Measurement ?? "default",
        @"[^\w\-]", 
        "_"
    );

    string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "LoghidCertificates");
    Directory.CreateDirectory(folderPath);


    var data = BuildDataDictionary(measurement);
    string contentForHash = string.Join("\n", data.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
    string hash = CalculateSHA256Hash(contentForHash);

    string fileName = $"Certificate_{measurement.Id_Measurement}_{hash}.pdf";
    string fullPath = Path.Combine(folderPath, fileName);

    try
    {
        
        using (var writer = new PdfWriter(fullPath))
        using (var pdf = new PdfDocument(writer))
        {
            var document = new Document(pdf);
            PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            
            document.Add(new Paragraph("Loghid Certificate Customer Measurement Report")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(16)
                .SetFont(boldFont));

            document.Add(new Paragraph($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12));

            document.Add(new Paragraph("Name: The name or type of the measured substance. ISO Threshold: The ISO-defined threshold value for quality measurement. Measurement Method: The specific method used for measurement. Measurement Range: The valid range of measured values. Probability: Likely represents the confidence level of the measurement.")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12));

            
            foreach (var item in data)
            {
                document.Add(new Paragraph($"{item.Key}: {item.Value}")
                    .SetFontSize(12));
            }

            
            document.Add(new Paragraph($"Document Hash (SHA-256): {hash}")
                .SetTextAlignment(TextAlignment.LEFT)
                .SetFontSize(12));
        }

        return PhysicalFile(fullPath, "application/pdf", fileName);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error completo: {ex.ToString()}");
        return BadRequest($"Error al generar el PDF: {ex.Message}");
    }
}

        private Dictionary<string, string> BuildDataDictionary(ClientMeasurement measurement)
        {
            return new Dictionary<string, string>
            {
                {"Measurement ID", measurement.Id_Measurement.ToString()},
            {"Public ID", measurement.PublicID_Measurement ?? "N/A"},
            {"Date", measurement.Date_Measurement.ToString("dd/MM/yyyy")},
            {"Customer ID", measurement.CustomerID_Measurement.ToString()},
            {"Customer", measurement.Customer_Measurement},
            {"Supplier ID", measurement.SupplierID_Measurement.ToString()},
            {"Supplier", measurement.Supplier_Measurement},
            {"Location", measurement.Location_Measurement},
            {"Notes", measurement.Notes_Measurement ?? "N/A"},
            {"Water", measurement.Water_Name_Measurement.ToString()},
            {"Water ISO Threshold", measurement.Water_ISO_Threshold_Measurement.ToString()},
            {"Water Measurement Method", measurement.Water_Measurement_Method_Measurement.ToString()},
            {"Water Measurement Range", measurement.Water_MeasuredRange_Measurement.ToString()},
            {"Water Probability", measurement.Water_Probability_Measurement.ToString()},
            {"Methane", measurement.Methane_SubstanceName_Measurement.ToString()},
            {"Methane ISO Threshold", measurement.Methane_IsoThreshold_Measurement.ToString()},
            {"Methane Measurement Method", measurement.Methane_MeasurementMethod_Measurement.ToString()},
            {"Methane Measurement Range", measurement.Methane_MeasuredRange_Measurement.ToString()},
            {"Methane Probability", measurement.Methane_Probability_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons", measurement.NonCH4Hydrocarbons_SubstanceName_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons ISO Threshold", measurement.NonCH4Hydrocarbons_IsoThreshold_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons Measurement Method", measurement.NonCH4Hydrocarbons_MeasurementMethod_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons Measurement Range", measurement.NonCH4Hydrocarbons_MeasuredRange_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons Probability", measurement.NonCH4Hydrocarbons_Probability_Measurement.ToString()},
            {"Oxygen", measurement.Oxygen_SubstanceName_Measurement.ToString()},
            {"Oxygen ISO Threshold", measurement.Oxygen_IsoThreshold_Measurement.ToString()},
            {"Oxygen Measurement Method", measurement.Oxygen_MeasurementMethod_Measurement.ToString()},
            {"Oxygen Measurement Range", measurement.Oxygen_MeasuredRange_Measurement.ToString()},
            {"Oxygen Probability", measurement.Oxygen_Probability_Measurement.ToString()},
            {"Helium", measurement.Helium_SubstanceName_Measurement.ToString()},
            {"Helium ISO Threshold", measurement.Helium_IsoThreshold_Measurement.ToString()},
            {"Helium Measurement Method", measurement.Helium_MeasurementMethod_Measurement.ToString()},
            {"Helium Measurement Range", measurement.Helium_MeasuredRange_Measurement.ToString()},
            {"Helium Probability", measurement.Helium_Probability_Measurement.ToString()},
            {"Nitrogen", measurement.Nitrogen_SubstanceName_Measurement.ToString()},
            {"Nitrogen ISO Threshold", measurement.Nitrogen_IsoThreshold_Measurement.ToString()},
            {"Nitrogen Measurement Method", measurement.Nitrogen_MeasurementMethod_Measurement.ToString()},
            {"Nitrogen Measurement Range", measurement.Nitrogen_MeasuredRange_Measurement.ToString()},
            {"Nitrogen Probability", measurement.Nitrogen_Probability_Measurement.ToString()},
            {"Argon", measurement.Argon_SubstanceName_Measurement.ToString()},
            {"Argon ISO Threshold", measurement.Argon_IsoThreshold_Measurement.ToString()},
            {"Argon Measurement Method", measurement.Argon_MeasurementMethod_Measurement.ToString()},
            {"Argon Measurement Range", measurement.Argon_MeasuredRange_Measurement.ToString()},
            {"Argon Probability", measurement.Argon_Probability_Measurement.ToString()},
            {"Carbon Dioxide", measurement.CarbonDioxide_SubstanceName_Measurement.ToString()},
            {"Carbon Dioxide ISO Threshold", measurement.CarbonDioxide_Argon_IsoThreshold_Measurement.ToString()},
            {"Carbon Dioxide Measurement Method", measurement.CarbonDioxide_Argon_MeasurementMethod_Measurement.ToString()},
            {"Carbon Dioxide Measurement Range", measurement.CarbonDioxide_Argon_MeasuredRange_Measurement.ToString()},
            {"Carbon Dioxide Probability", measurement.CarbonDioxide_Argon_Probability_Measurement.ToString()},
            {"Carbon Monoxide", measurement.CarbonMonoxid_SubstanceName_Measurement.ToString()},
            {"Carbon Monoxide ISO Threshold", measurement.CarbonMonoxid_IsoThreshold_Measurement.ToString()},
            {"Carbon Monoxide Measurement Method", measurement.CarbonMonoxid_MeasurementMethod_Measurement.ToString()},
            {"Carbon Monoxide Measurement Range", measurement.CarbonMonoxid_MeasuredRange_Measurement.ToString()},
            {"Carbon Monoxide Probability", measurement.CarbonMonoxid_Probability_Measurement.ToString()},
            {"Sulphur Compounds", measurement.SulphurCompounds_SubstanceName_Measurement.ToString()},
            {"Sulphur Compounds ISO Threshold", measurement.SulphurCompounds_IsoThreshold_Measurement.ToString()},
            {"Sulphur Compounds Measurement Method", measurement.SulphurCompounds_MeasurementMethod_Measurement.ToString()},
            {"Sulphur Compounds Measurement Range", measurement.SulphurCompounds_MeasuredRange_Measurement.ToString()},
            {"Sulphur Compounds Probability", measurement.SulphurCompounds_Probability_Measurement.ToString()},
            {"Formaldehyde", measurement.Formaldehyde_SubstanceName_Measurement.ToString()},
            {"Formaldehyde ISO Threshold", measurement.Formaldehyde_IsoThreshold_Measurement.ToString()},
            {"Formaldehyde Measurement Method", measurement.Formaldehyde_MeasurementMethod_Measurement.ToString()},
            {"Formaldehyde Measurement Range", measurement.Formaldehyde_MeasuredRange_Measurement.ToString()},
            {"Formaldehyde Probability", measurement.Formaldehyde_Probability_Measurement.ToString()},
            {"Formic Acid", measurement.FormicAcid_SubstanceName_Measurement.ToString()},
            {"Formic Acid ISO Threshold", measurement.FormicAcid_IsoThreshold_Measurement.ToString()},
            {"Formic Acid Measurement Method", measurement.FormicAcid_MeasurementMethod_Measurement.ToString()},
            {"Formic Acid Measurement Range", measurement.FormicAcid_MeasuredRange_Measurement.ToString()},
            {"Formic Acid Probability", measurement.FormicAcid_Probability_Measurement.ToString()},
            {"Ammonia", measurement.Amonia_SubstanceName_Measurement.ToString()},
            {"Ammonia ISO Threshold", measurement.Amonia_IsoThreshold_Measurement.ToString()},
            {"Ammonia Measurement Method", measurement.Amonia_MeasurementMethod_Measurement.ToString()},
            {"Ammonia Measurement Range", measurement.Amonia_MeasuredRange_Measurement.ToString()},
            {"Ammonia Probability", measurement.Amonia_Probability_Measurement.ToString()},
            {"Halogenated Compounds", measurement.HalogenatedCompounds_SubstanceName_Measurement.ToString()},
            {"Halogenated Compounds ISO Threshold", measurement.HalogenatedCompounds_IsoThreshold_Measurement.ToString()},
            {"Halogenated Compounds Measurement Method", measurement.HalogenatedCompounds_MeasurementMethod_Measurement.ToString()},
            {"Halogenated Compounds Measurement Range", measurement.HalogenatedCompounds_MeasuredRange_Measurement.ToString()},
            {"Halogenated Compounds Probability", measurement.HalogenatedCompounds_Probability_Measurement.ToString()},
            {"Hydrocarbons", measurement.Hydrocarbons_SubstanceName_Measurement.ToString()},
            {"Hydrocarbons ISO Threshold", measurement.Hydrocarbons_IsoThreshold_Measurement.ToString()},
            {"Hydrocarbons Measurement Method", measurement.Hydrocarbons_MeasurementMethod_Measurement.ToString()},
            {"Hydrocarbons Measurement Range", measurement.Hydrocarbons_MeasuredRange_Measurement.ToString()},
            {"Hydrocarbons Probability", measurement.Hydrocarbons_Probability_Measurement.ToString()}
            };
        }
    }
}