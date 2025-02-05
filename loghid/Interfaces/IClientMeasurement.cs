using System;

namespace Loghid.Models
{
    public interface IClientMeasurement
    {
        int Id_Measurement { get; set; }
        DateTimeOffset Date_Measurement { get; set; } // UTC + Offset
        string Location_Measurement { get; set; }
        decimal Value_Measurement { get; set; }
        string? Notes_Measurement { get; set; }
        double IsoThreshold_Measurement { get; set; }
        string MeasurementMethod_Measurement { get; set; }
        string MeasuredRange_Measurement { get; set; }
        string Probability_Measurement { get; set; }
    }
}
