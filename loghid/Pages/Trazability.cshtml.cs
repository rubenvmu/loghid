using CsvHelper;
using CsvHelper.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace loghid.Pages
{
    public class TrazabilityModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        public List<Location> Locations { get; private set; } = new List<Location>();

        public TrazabilityModel(IWebHostEnvironment env)
        {
            _env = env;
        }

        public void OnGet()
        {
            
            string csvPath = Path.Combine(_env.WebRootPath, "csv", "corridor.csv");
            if (!System.IO.File.Exists(csvPath))
            {
                Console.WriteLine("El archivo corridor.csv no existe en la ruta esperada.");
                Locations = new List<Location>();
                return;
            }

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = args => args.Header.ToLower()
                                                      .Replace("á", "a")
                                                      .Replace("é", "e")
                                                      .Replace("í", "i")
                                                      .Replace("ó", "o")
                                                      .Replace("ú", "u"),
                MissingFieldFound = null,
                BadDataFound = null,
                IgnoreBlankLines = true,
                HeaderValidated = null,  
                Delimiter = ","          
            };

            try
            {
                using (var reader = new StreamReader(csvPath))
                using (var csv = new CsvReader(reader, config))
                {
                    csv.Context.RegisterClassMap<LocationMap>(); 
                    Locations = csv.GetRecords<Location>().ToList();
                    Console.WriteLine($"Se cargaron {Locations.Count} registros desde el CSV.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el CSV: {ex.Message}");
                Locations = new List<Location>();
            }
        }
    }


    public sealed class LocationMap : ClassMap<Location>
    {
        public LocationMap()
        {
            Map(m => m.WKT).Name("WKT");
            Map(m => m.Nombre).Name("nombre");
            Map(m => m.Descripcion).Name("descripción");
        }
    }
}
