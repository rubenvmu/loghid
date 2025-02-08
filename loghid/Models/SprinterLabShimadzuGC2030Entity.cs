using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Loghid.Models
{
    public class SprinterLabShimadzuGC2030Entity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        // Add properties similar to SprinterLabShimadzuGC2030 class
        public string Vehiculo { get; set; } = "Mercedes-Benz Sprinter";
        public string TipoConversion { get; set; } = "Laboratorio móvil para análisis de hidrógeno";
        public double CapacidadCarga { get; set; } = 3500;
        public double EspacioInterior { get; set; } = 14.0;
        public string ModeloEquipo { get; set; } = "Shimadzu Nexis GC-2030";
        public string NormaHidrogeno { get; set; } = "ISO 19880-8";
        public string NormaPureza { get; set; } = "ISO 14687:2006";
        public double PurezaMinima { get; set; } = 98.0;
        public double PurezaOptima { get; set; } = 99.995;
        public string DetectorHidrogeno { get; set; } = "TCD - Thermal Conductivity Detector";
        public string DetectorHidrocarburos { get; set; } = "FID - Flame Ionization Detector";
        public string DetectorOxigenoOtros { get; set; } = "GC con sensibilidad 0.5 µmol/mol o 20%";
        public string DetectorAzufre { get; set; } = "FPD - Flame Photometric Detector";
        public int FiltroMinimoMicrones { get; set; } = 10;
        public int FiltroMaximoMicrones { get; set; } = 40;
        public string MetodoTomaMuestra { get; set; } = "Botella de un lote representativo";
        public string UnidadFraccionMolar { get; set; } = "%";
        public string UnidadContenidoAgua { get; set; } = "cm3/m3 (higrómetro electrolítico)";
        public string UnidadImpurezas { get; set; } = "µmol/mol";
        public string MetodoCalibracion { get; set; } = "Gas patrón de calibración con analito";
        public string NormaCalibracion { get; set; } = "ISO 21087";
        public bool EnsayoPresion { get; set; } = true;
        public bool EnsayoFugas { get; set; } = true;
        public bool EnsayoCalidadHidrogeno { get; set; } = true;
        public string CarrierGas { get; set; } = "He (Helio)";
        public string CarrierAlternativo { get; set; } = "N2 (requiere más tiempo de análisis)";
        public double SensibilidadMinima { get; set; } = 0.1;
        public bool SistemaAislamientoVibraciones { get; set; } = true;
        public bool SistemaClimatizacionControlada { get; set; } = true;
        public bool SistemaEnergiaIndependiente { get; set; } = true;

        // Precios
        public Precio PrecioVehiculo { get; set; } = new Precio();
        public Precio PrecioTipoConversion { get; set; } = new Precio();
        public Precio PrecioModeloEquipo { get; set; } = new Precio();
        public Precio PrecioNormaHidrogeno { get; set; } = new Precio();
        public Precio PrecioNormaPureza { get; set; } = new Precio();
        public Precio PrecioDetectorHidrogeno { get; set; } = new Precio();
        public Precio PrecioDetectorHidrocarburos { get; set; } = new Precio();
        public Precio PrecioDetectorOxigeno { get; set; } = new Precio();
        public Precio PrecioDetectorAzufre { get; set; } = new Precio();
        public Precio PrecioFiltrado { get; set; } = new Precio();
        public Precio PrecioMetodoTomaMuestra { get; set; } = new Precio();
        public Precio PrecioUnidadFraccionMolar { get; set; } = new Precio();
        public Precio PrecioUnidadContenidoAgua { get; set; } = new Precio();
        public Precio PrecioUnidadImpurezas { get; set; } = new Precio();
        public Precio PrecioMetodoCalibracion { get; set; } = new Precio();
        public Precio PrecioNormaCalibracion { get; set; } = new Precio();
        public Precio PrecioEnsayoPresion { get; set; } = new Precio();
        public Precio PrecioEnsayoFugas { get; set; } = new Precio();
        public Precio PrecioEnsayoCalidadHidrogeno { get; set; } = new Precio();
        public Precio PrecioCarrierGas { get; set; } = new Precio();
        public Precio PrecioCarrierAlternativo { get; set; } = new Precio();
        public Precio PrecioSensibilidadMinima { get; set; } = new Precio();
        public Precio PrecioSistemaAislamientoVibraciones { get; set; } = new Precio();
        public Precio PrecioSistemaClimatizacionControlada { get; set; } = new Precio();
        public Precio PrecioSistemaEnergiaIndependiente { get; set; } = new Precio();
    }
}
