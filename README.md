
# H2 In-Situ Measurement & e-Traceability Platform 🚀  

![.NET Version](https://img.shields.io/badge/.NET-9.0-purple) ![License](https://img.shields.io/badge/License-MIT-green)  

![Loghid](https://github.com/rubenvmu/loghid/blob/master/loghid/wwwroot/images/foto10.png?raw=true)  

## 📌 About  

Welcome to the **H2 Measurement & e-Traceability Platform**! 🌱  
This platform is designed to revolutionize the way we measure, track, and manage hydrogen (H2). Built with .NET technologies, it ensures transparency, accuracy, and efficiency in hydrogen-related operations.  

![Loghid](https://github.com/rubenvmu/loghid/blob/master/loghid/wwwroot/images/foto9.png?raw=true)

🔗 Visit us at: [loghid.com](https://loghid.com)  

![Loghid](https://github.com/rubenvmu/loghid/blob/master/loghid/wwwroot/images/foto4.png?raw=true)

```mermaid
flowchart TB
    subgraph Features["🚀 Features                                                                                    "]
        F1[Real-time H2 Measurement 📊]:::featureStyle
        F2[e-Traceability 🛤️]:::featureStyle
        F3[Interactive Dashboard 📈]:::featureStyle
        F4[Secure & Scalable 🔒]:::featureStyle
    end

    Features --> Space[ ]:::invisible

    subgraph Technologies["🛠️ Technologies Used                                                                 "]
        T1[.NET 9 🖥️]:::techStyle
        T2[SQLite 🗄️]:::techStyle
        T3[Hydrogen Analytics 🌿]:::techStyle
        T4[Dashboard Application 📊]:::techStyle
    end

    classDef featureStyle fill:#C8E6C9,stroke:#81C784,stroke-width:1px,min-width:250px
    classDef techStyle fill:#BBDEFB,stroke:#64B5F6,stroke-width:1px,min-width:250px
    classDef invisible fill:#ffffff00,stroke:#ffffff00,color:#ffffff00

    style Features fill:#E8F5E9,stroke:#4CAF50,stroke-width:2px,color:#2E7D32
    style Technologies fill:#E3F2FD,stroke:#2196F3,stroke-width:2px,color:#1565C0
```

![Loghid](https://github.com/rubenvmu/loghid/blob/master/loghid/wwwroot/images/foto2.png?raw=true)

## 📦 Installation  

1. Clone the repository:  

   ```bash
   git clone https://github.com/rubenvmu/loghid.git
   ```

2. Navigate to the project directory:  

   ```bash
   cd loghid
   ```

3. Install dependencies:  

   ```bash
   dotnet restore
   ```

4. Run the application:  

   ```bash
   dotnet run
   ```

---

![Loghid](https://github.com/rubenvmu/loghid/blob/master/loghid/wwwroot/images/foto6.png?raw=true)

## 📊 Loghid ISO Parameters Diagram

```mermaid
classDiagram
    direction BT

    class ISubstanceData {
        <<interface>>
        +int Id
        +string SubstanceName
        +double IsoThreshold
        +string MeasurementMethod
        +string MeasuredRange
        +string Probability
    }

    ISubstanceData <|.. Water
    ISubstanceData <|.. Methane
    ISubstanceData <|.. NonCH4Hydrocarbons
    ISubstanceData <|.. Oxygen
    ISubstanceData <|.. Helium
    ISubstanceData <|.. Nitrogen
    ISubstanceData <|.. Argon
    ISubstanceData <|.. CarbonDioxide
    ISubstanceData <|.. CarbonMonoxide
    ISubstanceData <|.. SulphurCompounds
    ISubstanceData <|.. Formaldehyde
    ISubstanceData <|.. FormicAcid
    ISubstanceData <|.. Ammonia
    ISubstanceData <|.. HalogenatedCompounds
    ISubstanceData <|.. Hydrocarbons

    class Water {
    }

    class Methane {
    }

    class NonCH4Hydrocarbons {
    }

    class Oxygen {
    }

    class Helium {
    }

    class Nitrogen {
    }

    class Argon {
    }

    class CarbonDioxide {
    }

    class CarbonMonoxide {
    }

    class SulphurCompounds {
    }

    class Formaldehyde {
    }

    class FormicAcid {
    }

    class Ammonia {
    }

    class HalogenatedCompounds {
    }

    class Hydrocarbons {
    }
```

---

## 📊 Loghid eMovilab Diagram

```mermaid
classDiagram
    direction BT
    
    class IeSprinterLab {
        <<interface>>
        +int Id
        +string Vehicle
        +double VehiclePrice
        +double CargoCapacity
        +double InteriorSpace
        +double AutonomyCapacity
        +double PricePer100km
        +double Chromatograph
        +double TCD
        +double FID
        +double Hygrometer
        +double FPD
        +double PressureRegulators
        +double StandardGasBottles
        +double GasColumns
        +double HeliumCarrierGas
        +double AirFuelGas
        +double ChromatographCertification
        +double RegulatoryConsultations
        +double AnalysisService
        +double Calibration
        +double VehicleMaintenance
        +double TotalPrice()* Calculated
    }

    class eSprinterLab {
        <<Entity>>
        +int Id
        +string Vehicle
        +double VehiclePrice
        +double CargoCapacity
        +double InteriorSpace
        +double AutonomyCapacity
        +double PricePer100km
        +double Chromatograph
        +double TCD
        +double FID
        +double Hygrometer
        +double FPD
        +double PressureRegulators
        +double StandardGasBottles
        +double GasColumns
        +double HeliumCarrierGas
        +double AirFuelGas
        +double ChromatographCertification
        +double RegulatoryConsultations
        +double AnalysisService
        +double Calibration
        +double VehicleMaintenance
        +double TotalPrice() Calculated
        
        note for eSprinterLab "Annotations:
        - [Key] (Primary Key)
        - [DatabaseGenerated]
        - [Required]
        - [MaxLength(100)]
        - [Range] validations
        - Default values set"
    }

    IeSprinterLab <|.. eSprinterLab
   ```

---

## 📜 License  

This project is licensed under the **MIT License**.  

---

## 📞 Contact  

For inquiries, collaborations, or support, reach out to us:  
📧 Email: [rvmu@araintel.com](mailto:rvmu@araintel.com)  

---

---
