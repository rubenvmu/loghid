using System;

namespace Loghid.Models
{
    public interface IClientMeasurement
    {
        int Id { get; set; }
        DateTimeOffset MeasurementDate { get; set; } // UTC + Offset
        string Location { get; set; }
        decimal Value { get; set; }
        string? Notes { get; set; }
        string SubstanceName { get; set; }
        double IsoThreshold { get; set; }
        string MeasurementMethod { get; set; }
        string MeasuredRange { get; set; }
        string Probability { get; set; }
    }
}
