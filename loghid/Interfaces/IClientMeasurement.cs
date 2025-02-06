using System;

namespace Loghid.Models
{
    public interface IClientMeasurement
    {
        int Id_Measurement { get; set; }

        string? PublicID_Measurement { get; }
        DateTimeOffset Date_Measurement { get; } // UTC + Offset

        int CustomerID_Measurement { get; set; }
        string Customer_Measurement { get; set; }

        int SupplierID_Measurement { get; set; }
        string Supplier_Measurement { get; set; }
        string Location_Measurement { get; set; }

        string? Notes_Measurement { get; set; }
       
    }
}
