using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;
using System.Text.RegularExpressions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Security.Cryptography;
using System.Text;

namespace loghid.Pages.Movilabs
{
    public class IndexModel : PageModel
    {
        private readonly Loghid.Data.eSprinterLabShimadzuDbContext _context;

        public IndexModel(Loghid.Data.eSprinterLabShimadzuDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<eSprinterLab> eSprinterLab { get; set; } = default!;

        public async Task OnGetAsync()
        {
            eSprinterLab = await _context.eSprinterLab.ToListAsync();
        }

        public async Task<IActionResult> OnGetDetailsAsync(int id)
        {
            var lab = await _context.eSprinterLab.FindAsync(id);
            if (lab == null)
            {
                return NotFound();
            }

            // Construye un diccionario con tus datos.
            var data = new Dictionary<string, string>
            {
                { "Id", lab.Id.ToString() },
                { "Vehicle", lab.Vehicle },
                { "Vehicle Price", lab.VehiclePrice.ToString("N2") },
                { "Total Price", lab.TotalPrice.ToString("N2") }
                // Agrega más propiedades según necesites
            };

            string contentForHash = string.Join("\n", data.Select(kvp => $"{kvp.Key}: {kvp.Value}"));
            string hash = CalculateSHA256Hash(contentForHash);

            // Crea la carpeta para el PDF si no existe
            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "LoghidCertificates");
            Directory.CreateDirectory(folderPath);

            string sanitizedVehicle = Regex.Replace(lab.Vehicle ?? "default", @"[^\w\-]", "_");
            string fileName = $"eSprinterLab_{lab.Id}_{hash}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);

            try
            {
                using (var writer = new PdfWriter(fullPath))
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);
                    PdfFont boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    document.Add(new Paragraph("Lab Certificate")
                        .SetFontSize(16)
                        .SetFont(boldFont));

                    document.Add(new Paragraph($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetFontSize(12));

                    foreach (var item in data)
                    {
                        document.Add(new Paragraph($"{item.Key}: {item.Value}")
                            .SetFontSize(12));
                    }

                    document.Add(new Paragraph($"SHA-256: {hash}")
                        .SetFontSize(12));
                }

                return PhysicalFile(fullPath, "application/pdf", fileName);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error generating PDF: {ex.Message}");
            }
        }

        public async Task<IActionResult> OnGetDownloadAsync(int id)
        {
            var lab = await _context.eSprinterLab.FindAsync(id);
            if (lab == null)
                return NotFound();

            var data = new Dictionary<string, string>
            {
                { "Id", lab.Id.ToString() },
                { "Vehicle", lab.Vehicle },
                { "VehiclePrice", lab.VehiclePrice.ToString("N2") },
                { "TotalPrice", lab.TotalPrice.ToString("N2") }
            };

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "LoghidCertificates");
            Directory.CreateDirectory(folderPath);

            string contentForHash = string.Join("\n", data.Select(k => $"{k.Key}: {k.Value}"));
            string hash = CalculateSHA256Hash(contentForHash);
            string fileName = $"SprinterLab_{lab.Id}_{hash}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);

            try
            {
                using (var writer = new PdfWriter(fullPath))
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);
                    PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    doc.Add(new Paragraph("Loghid Movilab Certificate").SetFont(bold).SetFontSize(16));
                    doc.Add(new Paragraph($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}"));

                    doc.Add(new Paragraph($"Id: {lab.Id}").SetFontSize(12));
                    doc.Add(new Paragraph($"Vehicle: {lab.Vehicle}").SetFontSize(12));
                    doc.Add(new Paragraph($"VehiclePrice: {lab.VehiclePrice:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"CargoCapacity: {lab.CargoCapacity:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"InteriorSpace: {lab.InteriorSpace:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"AutonomyCapacity: {lab.AutonomyCapacity:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"PricePer100km: {lab.PricePer100km:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"Chromatograph: {lab.Chromatograph:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"TCD: {lab.TCD:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"FID: {lab.FID:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"Hygrometer: {lab.Hygrometer:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"FPD: {lab.FPD:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"PressureRegulators: {lab.PressureRegulators:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"StandardGasBottles: {lab.StandardGasBottles:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"GasColumns: {lab.GasColumns:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"HeliumCarrierGas: {lab.HeliumCarrierGas:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"AirFuelGas: {lab.AirFuelGas:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"ChromatographCertification: {lab.ChromatographCertification:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"RegulatoryConsultations: {lab.RegulatoryConsultations:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"AnalysisService: {lab.AnalysisService:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"Calibration: {lab.Calibration:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"VehicleMaintenance: {lab.VehicleMaintenance:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"TotalPrice: {lab.TotalPrice:N2}").SetFontSize(12));
                    doc.Add(new Paragraph($"SHA-256: {hash}").SetFontSize(12));
                }

                return PhysicalFile(fullPath, "application/pdf", fileName);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error generating PDF: {ex.Message}");
            }
        }

        public async Task<IActionResult> OnGetDownloadAllAsync()
        {
            // Obtenemos todos los registros
            var labs = await _context.eSprinterLab.ToListAsync();
            if (labs == null || !labs.Any())
            {
                return NotFound("No records found.");
            }

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "LoghidCertificates");
            Directory.CreateDirectory(folderPath);

            string fileName = $"AllLabs_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);

            try
            {
                using (var writer = new PdfWriter(fullPath))
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf);
                    PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

                    doc.Add(new Paragraph("All eSprinter Labs")
                        .SetFont(bold).SetFontSize(16));
                    
                    // Recorremos todos los labs para agregarlos al PDF
                    int counter = 1;
                    foreach (var lab in labs)
                    {
                        doc.Add(new Paragraph($"Lab #{counter++}")
                            .SetFontSize(14).SetFont(bold));

                        doc.Add(new Paragraph($"Id: {lab.Id}").SetFontSize(12));
                        doc.Add(new Paragraph($"Vehicle: {lab.Vehicle}").SetFontSize(12));
                        doc.Add(new Paragraph($"VehiclePrice: {lab.VehiclePrice:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"CargoCapacity: {lab.CargoCapacity:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"InteriorSpace: {lab.InteriorSpace:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"AutonomyCapacity: {lab.AutonomyCapacity:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"PricePer100km: {lab.PricePer100km:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"Chromatograph: {lab.Chromatograph:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"TCD: {lab.TCD:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"FID: {lab.FID:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"Hygrometer: {lab.Hygrometer:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"FPD: {lab.FPD:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"PressureRegulators: {lab.PressureRegulators:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"StandardGasBottles: {lab.StandardGasBottles:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"GasColumns: {lab.GasColumns:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"HeliumCarrierGas: {lab.HeliumCarrierGas:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"AirFuelGas: {lab.AirFuelGas:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"ChromatographCertification: {lab.ChromatographCertification:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"RegulatoryConsultations: {lab.RegulatoryConsultations:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"AnalysisService: {lab.AnalysisService:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"Calibration: {lab.Calibration:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"VehicleMaintenance: {lab.VehicleMaintenance:N2}").SetFontSize(12));
                        doc.Add(new Paragraph($"TotalPrice: {lab.TotalPrice:N2}").SetFontSize(12));
                        
                        // Espacio entre registros
                        doc.Add(new Paragraph(" ").SetFontSize(6));
                    }
                }

                return PhysicalFile(fullPath, "application/pdf", fileName);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error generating PDF: {ex.Message}");
            }
        }

        private string CalculateSHA256Hash(string content)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(content));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLowerInvariant();
            }
        }
    }
}
