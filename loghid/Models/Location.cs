using CsvHelper.Configuration.Attributes;

public class Location
{
    [Name("WKT")]
    public string? WKT { get; set; }

    [Name("nombre")]
    public string? Nombre { get; set; }

    [Name("descripción")]
    public string? Descripcion { get; set; } = "Sin descripción";

    public string GetDescripcion() => string.IsNullOrWhiteSpace(Descripcion) ? "Sin descripción" : Descripcion;

    public (double Lat, double Lng)? Coordenadas
    {
        get
        {
            if (string.IsNullOrWhiteSpace(WKT)) return null;
            var parts = WKT.Trim().ToUpperInvariant().Replace("POINT (", "").Replace(")", "").Split(' ');
            if (parts.Length == 2 && double.TryParse(parts[0], out double lng) && double.TryParse(parts[1], out double lat))
            {
                return (lat, lng);
            }
            return null;
        }
    }

    public string Tipo => !string.IsNullOrWhiteSpace(WKT)
                            ? (WKT.Trim().ToUpperInvariant().StartsWith("POINT") ? "Point" 
                                : WKT.Trim().ToUpperInvariant().StartsWith("POLYGON") ? "Polygon" 
                                : "Unknown")
                            : "Unknown";
}

