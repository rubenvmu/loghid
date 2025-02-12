using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iText.Kernel.Pdf;
using iText.Kernel.Colors;
using iText.Layout;
using iText.IO.Image;
using System.Security.Cryptography;
using System.Text;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Hosting;
using Loghid.Data;
using Loghid.Models;

namespace Loghid.Pages
{
    public class CertificatesIndex : PageModel
    {
        private readonly LoghidClientMeasurementDbContext _context;

        private readonly IWebHostEnvironment _env;
        public IList<ClientMeasurement> ClientMeasurement { get; set; } = new List<ClientMeasurement>();

        public CertificatesIndex(
    LoghidClientMeasurementDbContext context,
    IWebHostEnvironment env)
{
    _context = context;
    _env = env; // Asegurarse de asignar a la variable miembro
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

    string fileName = $"CertificateCustomer_{measurement.Id_Measurement}_{hash}.pdf";
    string fullPath = Path.Combine(folderPath, fileName);

    try
{
    using (var writer = new PdfWriter(fullPath))
    using (var pdf = new PdfDocument(writer))
    {
        var document = new Document(pdf);
        PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

    string imagePath = Path.Combine(_env.WebRootPath, "images", "loghid_logo_es.png");
Console.WriteLine($"Intentando cargar imagen desde: {imagePath}"); // Debug

if (System.IO.File.Exists(imagePath))
{
    try
    {
        ImageData imageData = ImageDataFactory.Create(imagePath);
        Image image = new Image(imageData)
            .ScaleToFit(80, 80)
            .SetHorizontalAlignment(HorizontalAlignment.RIGHT)
            .SetMarginTop(10)
            .SetMarginRight(10);
        
        document.Add(image);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error al cargar imagen: {ex.Message}");
    }
}
else
{
    Console.WriteLine("¡Archivo de imagen no encontrado!");
}

    document.Add(new Paragraph("Certificate Customer Measurement Report")
    .SetTextAlignment(TextAlignment.LEFT)
    .SetFontSize(16)
    .SetFont(boldFont));

        document.Add(new Paragraph($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm} by Loghid SPAIN")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));

        document.Add(new Paragraph("This document provides a Certificate Customer Measurement Report - Loghid H2 Fingerprint, detailing the quality of hydrogen gas based on the ISO 14687 standard.")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));

        document.Add(new Paragraph("ISO_Threshold_Measurement: The maximum allowable concentration for a given substance, as defined by ISO 14687.")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));

        document.Add(new Paragraph("Measurement_Method: The technique used to measure the substance (e.g., GC, OFCEAS, NDIR).")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));

        document.Add(new Paragraph("Testing range to ensure the instrument is correctly calibrated and capable of detecting contamination.")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));

        Table table = new Table(2).UseAllAvailableWidth();

        table.AddCell(new Cell().Add(new Paragraph("Parameter").SetFont(boldFont))
            .SetBackgroundColor(ColorConstants.LIGHT_GRAY));
        table.AddCell(new Cell().Add(new Paragraph("Value").SetFont(boldFont))
            .SetBackgroundColor(ColorConstants.LIGHT_GRAY));

        HashSet<string> highlightedParameters = new HashSet<string>
        {
            "Water", "Methane", "Oxygen", "Nitrogen", "Carbon Dioxide", "Carbon Monoxide",
            "Sulphur Compounds", "Formaldehyde", "Formic Acid", "Ammonia", "Halogenated Compounds",
            "Hydrocarbons", "Non-CH4 Hydrocarbons", "Helium", "Argon"
        };

        foreach (var item in data)
        {
            bool isHighlighted = highlightedParameters.Contains(item.Key);

            var cellParam = new Cell().Add(new Paragraph(item.Key).SetFontSize(12));
            var cellValue = new Cell().Add(new Paragraph(item.Value).SetFontSize(12));

            if (isHighlighted)
            {
                cellParam.SetBackgroundColor(ColorConstants.LIGHT_GRAY);
                cellValue.SetBackgroundColor(ColorConstants.LIGHT_GRAY);
            }

            table.AddCell(cellParam);
            table.AddCell(cellValue);
        }

        document.Add(table);

        document.Add(new Paragraph($"SHA-256: {hash}")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));

        document.Add(new Paragraph($"SHA-256: {hash}")
            .SetTextAlignment(TextAlignment.LEFT)
            .SetFontSize(12));
    }

    return PhysicalFile(fullPath, "application/pdf", fileName);
}
    catch (Exception ex)
    {
        Console.WriteLine($"Error{ex.ToString()}");
        return BadRequest($"Error{ex.Message}");
    }
}

        private Dictionary<string, string> BuildDataDictionary(ClientMeasurement measurement)
        {
            return new Dictionary<string, string>
            {
            {"Measurement ID", measurement.Id_Measurement.ToString()},
            {"H2 Fingerprint", measurement.PublicID_Measurement ?? "N/A"},
            {"Date", measurement.Date_Measurement.ToString("dd/MM/yyyy")},
            {"Customer ID", measurement.CustomerID_Measurement.ToString()},
            {"Customer", measurement.Customer_Measurement},
            {"Supplier ID", measurement.SupplierID_Measurement.ToString()},
            {"Supplier", measurement.Supplier_Measurement},
            {"Location", measurement.Location_Measurement},
            {"Notes", measurement.Notes_Measurement ?? "N/A"},
            {"Water", measurement.Water_Name_Measurement.ToString()},
            {"Water ISO Threshold", measurement.Water_ISO_Threshold_Measurement.ToString() + " µmol/mol"},
            {"Water Measurement Method", measurement.Water_Measurement_Method_Measurement.ToString()},
            {"Water Measurement Range", measurement.Water_MeasuredRange_Measurement.ToString()},
            {"Methane", measurement.Methane_SubstanceName_Measurement.ToString()},
            {"Methane ISO Threshold", measurement.Methane_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Methane Measurement Method", measurement.Methane_MeasurementMethod_Measurement.ToString()},
            {"Methane Measurement Range", measurement.Methane_MeasuredRange_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons", measurement.NonCH4Hydrocarbons_SubstanceName_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons ISO Threshold", measurement.NonCH4Hydrocarbons_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Non-CH4 Hydrocarbons Measurement Method", measurement.NonCH4Hydrocarbons_MeasurementMethod_Measurement.ToString()},
            {"Non-CH4 Hydrocarbons Measurement Range", measurement.NonCH4Hydrocarbons_MeasuredRange_Measurement.ToString()},
            {"Oxygen", measurement.Oxygen_SubstanceName_Measurement.ToString()},
            {"Oxygen ISO Threshold", measurement.Oxygen_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Oxygen Measurement Method", measurement.Oxygen_MeasurementMethod_Measurement.ToString()},
            {"Oxygen Measurement Range", measurement.Oxygen_MeasuredRange_Measurement.ToString()},
            {"Helium", measurement.Helium_SubstanceName_Measurement.ToString()},
            {"Helium ISO Threshold", measurement.Helium_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Helium Measurement Method", measurement.Helium_MeasurementMethod_Measurement.ToString()},
            {"Helium Measurement Range", measurement.Helium_MeasuredRange_Measurement.ToString()},
            {"Nitrogen", measurement.Nitrogen_SubstanceName_Measurement.ToString()},
            {"Nitrogen ISO Threshold", measurement.Nitrogen_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Nitrogen Measurement Method", measurement.Nitrogen_MeasurementMethod_Measurement.ToString()},
            {"Nitrogen Measurement Range", measurement.Nitrogen_MeasuredRange_Measurement.ToString()},
            {"Argon", measurement.Argon_SubstanceName_Measurement.ToString()},
            {"Argon ISO Threshold", measurement.Argon_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Argon Measurement Method", measurement.Argon_MeasurementMethod_Measurement.ToString()},
            {"Argon Measurement Range", measurement.Argon_MeasuredRange_Measurement.ToString()},
            {"Carbon Dioxide", measurement.CarbonDioxide_SubstanceName_Measurement.ToString()},
            {"Carbon Dioxide ISO Threshold", measurement.CarbonDioxide_Argon_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Carbon Dioxide Measurement Method", measurement.CarbonDioxide_Argon_MeasurementMethod_Measurement.ToString()},
            {"Carbon Dioxide Measurement Range", measurement.CarbonDioxide_Argon_MeasuredRange_Measurement.ToString()},
            {"Carbon Monoxide", measurement.CarbonMonoxid_SubstanceName_Measurement.ToString()},
            {"Carbon Monoxide ISO Threshold", measurement.CarbonMonoxid_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Carbon Monoxide Measurement Method", measurement.CarbonMonoxid_MeasurementMethod_Measurement.ToString()},
            {"Carbon Monoxide Measurement Range", measurement.CarbonMonoxid_MeasuredRange_Measurement.ToString()},
            {"Sulphur Compounds", measurement.SulphurCompounds_SubstanceName_Measurement.ToString()},
            {"Sulphur Compounds ISO Threshold", measurement.SulphurCompounds_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Sulphur Compounds Measurement Method", measurement.SulphurCompounds_MeasurementMethod_Measurement.ToString()},
            {"Sulphur Compounds Measurement Range", measurement.SulphurCompounds_MeasuredRange_Measurement.ToString()},
            {"Formaldehyde", measurement.Formaldehyde_SubstanceName_Measurement.ToString()},
            {"Formaldehyde ISO Threshold", measurement.Formaldehyde_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Formaldehyde Measurement Method", measurement.Formaldehyde_MeasurementMethod_Measurement.ToString()},
            {"Formaldehyde Measurement Range", measurement.Formaldehyde_MeasuredRange_Measurement.ToString()},
            {"Formic Acid", measurement.FormicAcid_SubstanceName_Measurement.ToString()},
            {"Formic Acid ISO Threshold", measurement.FormicAcid_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Formic Acid Measurement Method", measurement.FormicAcid_MeasurementMethod_Measurement.ToString()},
            {"Formic Acid Measurement Range", measurement.FormicAcid_MeasuredRange_Measurement.ToString()},
            {"Ammonia", measurement.Amonia_SubstanceName_Measurement.ToString()},
            {"Ammonia ISO Threshold", measurement.Amonia_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Ammonia Measurement Method", measurement.Amonia_MeasurementMethod_Measurement.ToString()},
            {"Ammonia Measurement Range", measurement.Amonia_MeasuredRange_Measurement.ToString()},
            {"Halogenated Compounds", measurement.HalogenatedCompounds_SubstanceName_Measurement.ToString()},
            {"Halogenated Compounds ISO Threshold", measurement.HalogenatedCompounds_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Halogenated Compounds Measurement Method", measurement.HalogenatedCompounds_MeasurementMethod_Measurement.ToString()},
            {"Halogenated Compounds Measurement Range", measurement.HalogenatedCompounds_MeasuredRange_Measurement.ToString()},
            {"Hydrocarbons", measurement.Hydrocarbons_SubstanceName_Measurement.ToString()},
            {"Hydrocarbons ISO Threshold", measurement.Hydrocarbons_IsoThreshold_Measurement.ToString() + " µmol/mol"},
            {"Hydrocarbons Measurement Method", measurement.Hydrocarbons_MeasurementMethod_Measurement.ToString()},
            {"Hydrocarbons Measurement Range", measurement.Hydrocarbons_MeasuredRange_Measurement.ToString()},
            };
        }
    }
}