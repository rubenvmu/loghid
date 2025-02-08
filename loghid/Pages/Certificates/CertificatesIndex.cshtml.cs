using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Loghid.Data;
using Loghid.Models;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using Microsoft.AspNetCore.Mvc.RazorPages;

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

        public async Task OnGetAsync()
        {
            ClientMeasurement = await _context.Measurements.ToListAsync();
        }

        public async Task<IActionResult> OnGetDownloadAsync(int id)
        {
            var measurement = await _context.Measurements.FindAsync(id);
            if (measurement == null)
            {
                return NotFound();
            }

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "loghid", "LoghidCertificates");
            if (!Directory.Exists(folderPath))
            {
                try
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine($"Directorio creado: {folderPath}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error al crear el directorio: {ex.Message}");
                    return BadRequest("No se pudo crear el directorio para los certificados.");
                }
            }

            string sanitizedPublicId = measurement.PublicID_Measurement?.Replace(" ", "_") ?? "default";
            string fileName = $"Certificate_{sanitizedPublicId}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            string fullPath = Path.Combine(folderPath, fileName);

            Console.WriteLine($"Intentando generar PDF en: {fullPath}");

            try
            {
                using (var writer = new PdfWriter(fullPath))
                using (var pdf = new PdfDocument(writer))
                using (var document = new Document(pdf))
                {
                    document.Add(new Paragraph("Loghid Certificates Report")
                        .SetTextAlignment(TextAlignment.CENTER)
                        .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))
                        .SetFontSize(16));

                    var data = new Dictionary<string, string>
                    {
                        {"Measurement ID", measurement.Id_Measurement.ToString()},
                        {"Public ID", measurement.PublicID_Measurement ?? "N/A"},
                        {"Date", measurement.Date_Measurement.ToString("dd/MM/yyyy")},
                        {"Customer ID", measurement.CustomerID_Measurement.ToString()},
                        {"Supplier ID", measurement.SupplierID_Measurement.ToString()},
                        {"Location", measurement.Location_Measurement ?? "N/A"},
                        {"Notes", measurement.Notes_Measurement ?? "N/A"}
                    };

                    Table table = new Table(2).UseAllAvailableWidth().SetMarginTop(20);
                    foreach (var item in data)
                    {
                        table.AddCell(new Cell().Add(new Paragraph(item.Key)
                            .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD))));
                        table.AddCell(new Cell().Add(new Paragraph(item.Value)));
                    }
                    document.Add(table);

                    document.Add(new Paragraph($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}")
                        .SetTextAlignment(TextAlignment.RIGHT)
                        .SetFont(PdfFontFactory.CreateFont(StandardFonts.HELVETICA_OBLIQUE))
                        .SetFontSize(10));
                }

                if (System.IO.File.Exists(fullPath))
                {
                    long fileSize = new FileInfo(fullPath).Length;
                    if (fileSize == 0)
                    {
                        Console.WriteLine("El archivo PDF está vacío.");
                        return BadRequest("El PDF generado está vacío.");
                    }
                    Console.WriteLine($"PDF generado correctamente. Tamaño: {fileSize} bytes.");
                    return PhysicalFile(fullPath, "application/pdf", fileName);
                }
                else
                {
                    Console.WriteLine("El archivo no se generó.");
                    return BadRequest("El PDF no se generó correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar el PDF: {ex.Message}");
                return BadRequest("Se produjo un error al generar el PDF.");
            }
        }
    }
}