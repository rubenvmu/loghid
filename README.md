
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

## 📊 Competitors

```mermaid
flowchart LR
    subgraph Competitors
        direction TB
        subgraph C1["LOGHID"]
            C1_1[ISO: RFNBO, 14687, 19880-8]
            C1_2[Real-Time: Yes]
            C1_3[Traceability: H2 Footprint]
            C1_4[UI: Intuitive]
            C1_5[Infra Req.: Very Low]
            C1_6[Automation: Loghid Cert.]
            C1_7[Security: AES-256]
            C1_8[Reg. Compliance: RFNBO]
            C1_9[Integration: High (API REST)]
            C1_10[Support: Continuous]
            C1_11[Mobility: National]
            C1_12[Open Source: Yes]
            C1_13[Model: Non-Profit]
        end

        subgraph C2["LHYFE + ATMEN"]
            C2_1[ISO: RFNBO, 14687]
            C2_2[Real-Time: High]
            C2_3[Traceability: Digital Passport]
            C2_4[UI: Medium]
            C2_5[Infra Req.: Medium]
            C2_6[Automation: RFNBO Auto.]
            C2_7[Security: High]
            C2_8[Reg. Compliance: RFNBO]
            C2_9[Integration: Medium (Atmen)]
            C2_10[Support: Regional]
            C2_11[Mobility: Commercial]
            C2_12[Open Source: No]
            C2_13[Model: Commercial]
        end
    end

    style C1 fill:#E8F5E9,stroke:#4CAF50,stroke-width:2px,color:#2E7D32
    style C2 fill:#E3F2FD,stroke:#2196F3,stroke-width:2px,color:#1565C0

    classDef default fill:#ffffff,stroke:#607D8B
    classDef c1Style fill:#C8E6C9,stroke:#81C784,stroke-width:1px
    classDef c2Style fill:#BBDEFB,stroke:#64B5F6,stroke-width:1px

    class C1_1,C1_2,C1_3,C1_4,C1_5,C1_6,C1_7,C1_8,C1_9,C1_10,C1_11,C1_12,C1_13 c1Style
    class C2_1,C2_2,C2_3,C2_4,C2_5,C2_6,C2_7,C2_8,C2_9,C2_10,C2_11,C2_12,C2_13 c2Style
```

## 📊 Loghid First Year Investment Flowchart

---

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

## 📊 Loghid H2 Fingerprint - SHA256 Hash

```mermaid
flowchart TB
    A[User accesses /Certificates] --> B[GET: OnGetAsync]
    B --> C[Load measurements from DB]
    C --> D{Display list}
    
    D --> |User selects| E[GET: OnGetDownloadAsync?id]
    E --> F[Search for measurement in DB]
    F --> G{Does it exist?}
    G --> |No| H[Return 404]
    G --> |Yes| I[Sanitize PublicID]
    I --> J[Create LoghidCertificates directory]
    J --> K[Build data dictionary]
    K --> L[Calculate SHA-256 of data]
    L --> M[Generate PDF with iText]
    M --> N["PDF Content:
    - Styled header
    - Measurement metadata
    - Substance values
    - SHA-256 hash"]
    N --> O[Save as H2Fingerprint_ID_HASH.pdf]
    O --> P[Return physical file]
    
    G --> |Error| Q[Log to console]
    M --> |Error| Q
    Q --> R[Return 400 with error]
    
    style A stroke:#4CAF50,stroke-width:2px
    style E stroke:#2196F3
    style L stroke:#FF9800
    style O stroke:#9C27B0
    style H,R stroke:#f44336
    style N fill:#FFF3E0
    
    classDef default fill:#ffffff,stroke:#607D8B
    classDef process fill:#E3F2FD,stroke:#1976D2
    classDef decision fill:#FFF8E1,stroke:#FFA000
    
    class A,E,L,O process
    class G decision
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
