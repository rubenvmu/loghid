
# H2 In-Situ Measurement & e-Traceability Platform 🚀  

![.NET Version](https://img.shields.io/badge/.NET-9.0-purple) ![License](https://img.shields.io/badge/License-MIT-green)  

![Loghid](https://i.imgur.com/JA0DOEw.png)  

## 📌 About  

Welcome to the **H2 Measurement & e-Traceability Platform**! 🌱  
This platform is designed to revolutionize the way we measure, track, and manage hydrogen (H2) data across Europe. Built with cutting-edge technology, it ensures transparency, accuracy, and efficiency in hydrogen-related operations.  

![Screen1](https://i.imgur.com/DS2Yh0f.png)
![Screen4](https://i.imgur.com/0Z0bqGq.png)
![Screen2](https://i.imgur.com/CiDhUUW.png)
![Screen3](https://i.imgur.com/IDwoXgi.png)

🔗 Visit us at: [loghid.com](https://loghid.com)  

---

## 🚀 Features  

- **Real-time H2 Measurement** 📊  
- **e-Traceability** 🛤️  
- **Interactive Dashboard** 📈  
- **Data Analytics** 🔍  
- **Secure & Scalable** 🔒  

---

## 🛠️ Technologies Used  

- **.NET 9** 🖥️  
- **SQLite** 🗄️  
- **Hydrogen Analytics** 🌿  
- **Dashboard Application** 📊  

---

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

## 🌐 Usage  

1. Log in to the platform.  
2. Access the **Dashboard** for real-time H2 measurements.  
3. Follow the **H2 Fingerprint** feature to track hydrogen data.  
4. Generate reports and analytics for better decision-making.  

---

## 📊 Loghid ISO structure 

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

## 📊 Loghid eMovilab structure

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
        +double TotalPrice()* «calculated»
    }

    class eSprinterLab {
        <<Entity>>
        -[Key]«PK» [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        +int Id
        
        -[Required][MaxLength(100)]
        +string Vehicle = "Mercedes-Benz Sprinter"
        
        -[Range(0, double.MaxValue)]
        +double VehiclePrice
        
        -[Display("Cargo Capacity (kg)")][Range(0, double.MaxValue)]
        +double CargoCapacity = 2854.0
        
        -[Display("Interior Space (m³)")][Range(0, double.MaxValue)]
        +double InteriorSpace = 14.0
        
        -[Display("Autonomy Capacity")][Range(0, double.MaxValue)]
        +double AutonomyCapacity
        
        -[Display("Price per 100km")][Range(0, double.MaxValue)]
        +double PricePer100km

        %% Chromatography Equipment
        -[Range(0, double.MaxValue)]
        +double Chromatograph = 65000.0
        +double TCD = 8000.0
        +double FID = 1400.0
        +double Hygrometer = 1500.0
        +double FPD = 3350.0

        %% Gas System
        -[Range(0, double.MaxValue)]
        +double PressureRegulators = 2000.0
        +double StandardGasBottles = 2550.0
        +double GasColumns = 3000.0
        +double HeliumCarrierGas = 200.0
        +double AirFuelGas = 150.0

        %% Certifications & Services
        -[Range(0, double.MaxValue)]
        +double ChromatographCertification = 3000.0
        +double RegulatoryConsultations = 1000.0
        +double AnalysisService = 640.0
        +double Calibration = 300.0
        +double VehicleMaintenance = 20.0

        +double TotalPrice() «calculated» 
    }

    IeSprinterLab <|.. eSprinterLab : implements
    ```

---

## 📊 Loghid First Year Investment Flowchart

```mermaid
%%{init: {'theme': 'neutral', 'themeVariables': { 'primaryColor': '#ffffff', 'edgeLabelBackground':'#fff', 'tertiaryColor': '#fff0f0'}}}%%
graph TB
    A[LOGHID Setup Costs] --> B[One-Time Costs]
    A --> C[Annual Costs]
    A --> D[Total 1st Year Investment]
    
    %% One-Time Costs
    B --> E[Association Registration: €150]
    B --> F[Notary: €80-120]
    B --> G[Registration: €50-100]
    B --> H[Legal Advisory: €400-600]
    B --> I[Bank Account: €0-100]
    B --> J[Trademark Registration: €150]
    B --> K[Other Costs: €200-400]
    
    %% Annual Costs
    C --> L[Liability Insurance: €250-400]
    C --> M[Accounting: €600-1200]
    C --> N[Web/Hosting: €100-200]
    C --> O[Domain: €100-200]
    
    %% Totals
    D --> P[Setup Total: €780-1220]
    D --> Q[Operation Total: €1150-2200]
    D --> R[Total Investment: €1930-3420]
    
    %% Validation
    A --> S[Validation & Support]
    S --> T[Zoilo Ríos]
    S --> U[30 People Survey]
    U --> V[86% Satisfaction]
    
    style A fill:#2ecc71,stroke:#27ae60,color:#fff
    style B,C fill:#3498db,stroke:#2980b9,color:#fff
    style E,F,G,H,I,J,K,L,M,N,O fill:#e67e22,stroke:#d35400
    style P,Q,R fill:#9b59b6,stroke:#8e44ad,color:#fff
    style S,T,U,V fill:#f1c40f,stroke:#f39c12
```

---

## 📊 Loghid Organizational Flowchart

```mermaid
%%{init: {'theme': 'neutral', 'themeVariables': { 'primaryColor': '#ffffff', 'edgeLabelBackground':'#fff', 'tertiaryColor': '#fff0f0'}}}%%
graph TB
    A[Non-Profit Organization] --> B[Analysis and Certification]
    A --> C[Technical Consulting]
    A --> D[Subscription Management]
    A --> E[Expansion and Alliances]

    %% Certification Block
    B --> F[Technology Providers]
    F --> G[[Equipment: Chromatographs, Vehicles, Hygrometer]]
    B --> H[[Revenue: Subscription]]
    B --> I[Hydroliners/Generators]

    %% Consulting Block
    C --> J[Regulatory Audits]
    C --> K[[Revenue: Consulting Fees]]
    C --> L[Regulators: AENOR/ENAC]

    %% Subscriptions Block
    D --> M[[Monthly/Annual Subscriptions]]
    D --> N[[Technical Training]]
    D --> O[Registered Clients]

    %% Expansion and Validation Block
    E --> P[Strategic Alliances]
    P --> Q[ARPA]
    P --> R[Ibercaja]
    P --> S[Hydrogen Aragon Foundation]
    P --> T[EbroH2]
    
    E --> U[Validation]
    U --> V[Zoilo Ríos]
    U --> W[Survey: 30 people]
    W --> X[10 H2 Professionals]
    W --> Y[80% Consider Loghid Necessary]

    style A fill:#2ecc71,stroke:#27ae60,color:#fff
    style B,C,D,E fill:#3498db,stroke:#2980b9,color:#fff
    style F,P fill:#e67e22,stroke:#d35400
    style H,K,M,N fill:#9b59b6,stroke:#8e44ad,color:#fff
    style I,O,Q,R,S,T,V,W fill:#f1c40f,stroke:#f39c12
    style X,Y fill:#2ecc71,stroke:#27ae60,color:#fff
```

---

## 📜 License  

This project is licensed under the **MIT License**.  

---

## 📞 Contact  

For inquiries, collaborations, or support, reach out to us:  
📧 Email: [info@loghid.com](mailto:info@loghid.com)  
🌐 Website: [loghid.com](https://loghid.com)  

---

---
