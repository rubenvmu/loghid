using Loghid.Models;

namespace Loghid.Interfaces
{
    public interface ISprinterLabShimadzuGC2030
    {
        int Id { get; set; }
        string Vehiculo { get; set; }
        string TipoConversion { get; set; }
        double CapacidadCarga { get; set; }
        double EspacioInterior { get; set; }
        string ModeloEquipo { get; set; }
        string NormaHidrogeno { get; set; }
        string NormaPureza { get; set; }
        double PurezaMinima { get; set; }
        double PurezaOptima { get; set; }
        string DetectorHidrogeno { get; set; }
        string DetectorHidrocarburos { get; set; }
        string DetectorOxigenoOtros { get; set; }
        string DetectorAzufre { get; set; }
        int FiltroMinimoMicrones { get; set; }
        int FiltroMaximoMicrones { get; set; }
        string MetodoTomaMuestra { get; set; }
        string UnidadFraccionMolar { get; set; }
        string UnidadContenidoAgua { get; set; }
        string UnidadImpurezas { get; set; }
        string MetodoCalibracion { get; set; }
        string NormaCalibracion { get; set; }
        bool EnsayoPresion { get; set; }
        bool EnsayoFugas { get; set; }
        bool EnsayoCalidadHidrogeno { get; set; }
        string CarrierGas { get; set; }
        string CarrierAlternativo { get; set; }
        double SensibilidadMinima { get; set; }
        bool SistemaAislamientoVibraciones { get; set; }
        bool SistemaClimatizacionControlada { get; set; }
        bool SistemaEnergiaIndependiente { get; set; }
    }
}
