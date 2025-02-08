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
                Console.WriteLine("Measurement not found.");
                return NotFound();
            }

            Console.WriteLine($"Measurement found: ID = {measurement.Id_Measurement}, Public ID = {measurement.PublicID_Measurement}");

            string folderPath = Path.Combine(Directory.GetCurrentDirectory(), "LoghidCertificates");
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
            string fileName = $"Certificate_{sanitizedPublicId}_{DateTime.Now:yyyyMMddHHmmss}.txt";
            string fullPath = Path.Combine(folderPath, fileName);

            Console.WriteLine($"Intentando generar TXT en: {fullPath}");

            try
            {
                var data = new Dictionary<string, string>
                {
                    {"Measurement ID", measurement.Id_Measurement.ToString()},
                    {"Public ID", measurement.PublicID_Measurement ?? "N/A"},
                    {"Date", measurement.Date_Measurement.ToString("dd/MM/yyyy")},
                    {"Customer ID", measurement.CustomerID_Measurement.ToString()},
                    {"Customer", measurement.Customer_Measurement},
                    {"Supplier ID", measurement.SupplierID_Measurement.ToString()},
                    {"Supplier", measurement.Supplier_Measurement},
                    {"Location", measurement.Location_Measurement},
                    {"Notes", measurement.Notes_Measurement ?? "N/A"}
                };

                using (var writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine("Loghid Certificates Report");
                    writer.WriteLine("==========================");
                    foreach (var item in data)
                    {
                        writer.WriteLine($"{item.Key}: {item.Value}");
                    }
                    writer.WriteLine("==========================");
                    writer.WriteLine($"Generated on: {DateTime.Now:dd/MM/yyyy HH:mm}");
                }

                if (System.IO.File.Exists(fullPath))
                {
                    long fileSize = new FileInfo(fullPath).Length;
                    if (fileSize == 0)
                    {
                        Console.WriteLine("El archivo TXT está vacío.");
                        return BadRequest("El TXT generado está vacío.");
                    }
                    Console.WriteLine($"TXT generado correctamente. Tamaño: {fileSize} bytes.");
                    return PhysicalFile(fullPath, "text/plain", fileName);
                }
                else
                {
                    Console.WriteLine("El archivo no se generó.");
                    return BadRequest("El TXT no se generó correctamente.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al generar el TXT: {ex.Message}");
                return BadRequest("Se produjo un error al generar el TXT.");
            }
        }
    }
}