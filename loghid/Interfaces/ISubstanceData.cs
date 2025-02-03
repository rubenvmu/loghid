public interface ISubstanceData {
        int Id { get; set; }
        string SubstanceName { get; set; }
        double IsoThreshold { get; set; }
        string MeasurementMethod { get; set; }
        string MeasuredRange { get; set; }
        string Probability { get; set; } 
}
