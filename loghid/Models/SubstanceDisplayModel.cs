public class SubstanceDisplayModel
{
    public string Name { get; set; } = null!;
    public int Id { get; set; }
    public double IsoThreshold { get; set; }
    public double PemResultMin { get; set; }
    public double PemResultMax { get; set; }
    public string Probability { get; set; } = null!;

    // Método para establecer los resultados de PEM según el tipo de sustancia
 public void SetPemResults(object pemResults)
{
    // Usamos dynamic para acceder a las propiedades de forma flexible
    dynamic result = pemResults;

    // Aquí validamos si las propiedades existen y las asignamos
    PemResultMin = result.PemResultMin ?? 0.0;
    PemResultMax = result.PemResultMax ?? 0.0;
}
}