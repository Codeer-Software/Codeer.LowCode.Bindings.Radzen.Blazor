# Project Structure - Radzen Bindings

## Solution Structure

```
Codeer.LowCode.Bindings.Radzen.Blazor.sln
├── Codeer.LowCode.Bindings.Radzen.Blazor/           # メインライブラリ
├── Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers/  # Selenium テストドライバ
├── Example/
│   ├── LowCodeApp.Client/           # Blazor WebAssembly クライアント
│   ├── LowCodeApp.Client.Shared/    # クライアント共有ライブラリ
│   ├── LowCodeApp.Server/           # ASP.NET Core サーバー
│   ├── LowCodeApp.Server.Shared/    # サーバー共有ライブラリ
│   ├── LowCodeApp.Designer/         # WPF デザイナー
│   └── SeleniumTest/                # Example 用 Selenium テスト
└── Test/
    ├── SeleniumTest/                 # メインの Selenium テスト
    └── SeleniumTestData/            # テストデータ
```

## NuGet パッケージバージョン (2026-02-28 更新)

### メインライブラリ
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor | 1.2.49 |
| Radzen.Blazor | 5.2.9 |
| Microsoft.AspNetCore.Components.Web | 8.0.24 |
| Microsoft.Extensions.Http | 8.0.1 |

### Example/LowCodeApp.Client
| Package | Version |
|---|---|
| Microsoft.AspNetCore.Components.WebAssembly | 8.0.24 |

### Example/LowCodeApp.Client.Shared
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor | 1.2.49 |
| Excel.Report.PDF | 0.32.0 |
| Microsoft.AspNetCore.WebUtilities | 8.0.24 |
| Microsoft.AspNetCore.Components.WebAssembly | 8.0.24 |
| Microsoft.AspNetCore.SignalR.Client | 8.0.24 |
| Microsoft.Extensions.Http | 8.0.1 |
| Sotsera.Blazor.Toaster | 3.0.0 |

### Example/LowCodeApp.Server.Shared
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor | 1.2.49 |
| Microsoft.Data.SqlClient | 5.2.2 |
| Npgsql | 8.0.5 |
| Oracle.ManagedDataAccess.Core | 23.6.0 |
| System.Data.SQLite | 1.0.119 |
| Microsoft.EntityFrameworkCore | 8.0.24 |
| Microsoft.EntityFrameworkCore.Relational | 8.0.24 |
| Dapper | 2.1.66 |

### Example/LowCodeApp.Server
| Package | Version |
|---|---|
| Azure.Storage.Blobs | 12.22.1 |
| Microsoft.AspNetCore.Components.WebAssembly.Server | 8.0.24 |
| Microsoft.CodeAnalysis.CSharp | 4.11.0 |
| Microsoft.CodeAnalysis.Common | 4.11.0 |
| Microsoft.CodeAnalysis.Workspaces.Common | 4.11.0 |
| Microsoft.CodeAnalysis.CSharp.Workspaces | 4.11.0 |

### Example/LowCodeApp.Designer
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor.Designer | 1.2.49 |

## メインライブラリ ファイル構成

```
Codeer.LowCode.Bindings.Radzen.Blazor/
├── Codeer.LowCode.Bindings.Radzen.Blazor.csproj
├── _Imports.razor
│
├── Components/                      # 17 フィールドコンポーネント
│   ├── RadzenTextFieldComponent.razor
│   ├── RadzenNumberFieldComponent.razor
│   ├── RadzenBooleanFieldComponent.razor
│   ├── RadzenDateFieldComponent.razor
│   ├── RadzenDateTimeFieldComponent.razor
│   ├── RadzenTimeFieldComponent.razor
│   ├── RadzenButtonFieldComponent.razor
│   ├── RadzenSubmitButtonFieldComponent.razor
│   ├── RadzenLinkFieldComponent.razor
│   ├── RadzenSelectFieldComponent.razor
│   ├── RadzenIdFieldComponent.razor
│   ├── RadzenRadioGroupFieldComponent.razor
│   ├── RadzenRadioButtonFieldComponent.razor
│   ├── RadzenPasswordFieldComponent.razor
│   ├── RadzenFileFieldComponent.razor
│   ├── RadzenChartFieldComponent.razor      # 独自
│   └── (各 .razor.css ファイル)
│
├── Designs/                         # 16 デザインクラス
│   ├── RadzenTextFieldDesign.cs
│   ├── RadzenNumberFieldDesign.cs
│   ├── RadzenBooleanFieldDesign.cs
│   ├── RadzenDateFieldDesign.cs
│   ├── RadzenDateTimeFieldDesign.cs
│   ├── RadzenTimeFieldDesign.cs
│   ├── RadzenButtonFieldDesign.cs
│   ├── RadzenSubmitButtonFieldDesign.cs
│   ├── RadzenLinkFieldDesign.cs
│   ├── RadzenSelectFieldDesign.cs
│   ├── RadzenIdFieldDesign.cs
│   ├── RadzenRadioGroupFieldDesign.cs
│   ├── RadzenRadioButtonFieldDesign.cs
│   ├── RadzenPasswordFieldDesign.cs
│   ├── RadzenFileFieldDesign.cs
│   └── RadzenChartFieldDesign.cs            # 独自
│
├── Search/                          # 10 検索コンポーネント
│   ├── RadzenTextComponent.razor
│   ├── RadzenNumberComponent.razor
│   ├── RadzenBooleanComponent.razor
│   ├── RadzenDateComponent.razor
│   ├── RadzenDateTimeComponent.razor
│   ├── RadzenTimeComponent.razor
│   ├── RadzenLinkComponent.razor
│   ├── RadzenSelectComponent.razor
│   ├── RadzenRadioGroupComponent.razor
│   └── RadzenFileComponent.razor
│
├── Infrastructure/
│   └── RadzenFieldComponentBase.cs  # 基底クラス
│
├── Internal/
│   ├── DateTimeHelper.cs
│   ├── MatchConditionDropdown.razor
│   └── Components/
│       └── Validator.razor
│
├── Enums/
│   ├── RadzenColor.cs
│   ├── RadzenVariant.cs
│   └── RadzenChartType.cs
│
├── Fields/
│   └── RadzenChartField.cs          # 独自フィールド
│
├── Models/
│   ├── ChartItem.cs
│   └── ChartSeries.cs
│
├── Installer/
│   ├── RadzenInstaller.razor
│   └── RadzenLoader.cs
│
└── Properties/
    ├── Resource.resx
    └── Resource.Designer.cs
```

## SeleniumDrivers 構成

```
Codeer.LowCode.Bindings.Radzen.Blazor.SeleniumDrivers/
├── Components/          # 15 フィールドドライバ
├── Native/              # Radzen ネイティブコンポーネント用ドライバ
│   ├── RadzenDateDriver.cs
│   ├── RadzenDateTimeDriver.cs
│   ├── RadzenDropDownDriver.cs
│   ├── RadzenRadioButtonDriver.cs
│   ├── RadzenTimeDriver.cs
│   └── RadzenToggleButtonDriver.cs
└── Search/              # 12 検索フィールドドライバ
```
