# Bindings.Radze.Blazor

[Codeer.LowCode.Blazor](https://github.com/Codeer-Software/Codeer.LowCode.Blazor.Manual/blob/main/JP/README.md)に[Radzen Blazor](https://github.com/radzenhq/radzen-blazor)コンポーネントを追加するためのライブラリです。

## インストール

### パッケージのインストール

LowCodeApp.Client.Shared プロジェクトにNuGetから次のパッケージをインストールしてください。

- Codeer.LowCode.Bindings.Radzen.Blazor

### コードの修正

ライブラリの使用に必要なコードを以下のプロジェクトにそれぞれ追加する必要があります。

- LowCodeApp.Client
- LowCodeApp.Shared
- LowCodeApp.Designer

#### LowCodeApp.Client

`Program.cs` に以下のコードを追加してください。

```csharp
RadzenLoader.LoadAssemblies();
builder.Services.AddRadzenComponents();
```

`MainLayout.razor` に以下のコードを追加してください。

```html
@using Codeer.LowCode.Bindings.Radzen.Blazor.Installer

<RadzenInstaller />
```

#### LowCodeApp.Server

`Program.cs` に以下のコードを追加してください。

```csharp
RadzenLoader.LoadAssemblies();
```

#### LowCodeApp.Designer

`App.xaml.cs` に以下のコードを追加してください。

```csharp
RadzenLoader.LoadAssemblies();
Services.AddRadzenComponents();
BlazorRuntime.InstallAssemblyInitializer(typeof(MudBlazorInstaller).Assembly);
BlazorRuntime.InstallRenderProvider(typeof(RadzenInstaller));
```

## 使用方法

DesignerからMudBlazor UIを使用したコンポーネントが配置できるようになっています。
通常のButtonやBooleanの代わりにRadzenButtonやRadzenBooleanを使用してください。

// 画像

## サポートしているタイプ

Codeer.LowCode.Blazorの標準コントロールに対応するMudBlazorコントロールは以下の通りです。

| Codeer.LowCode.Blazor | Radzen Blazor |
| --- | --- |
| Boolean | RadzenBoolean |
| Button | RadzenButton |
| Date | RadzenDate |
| DateTime | RadzenDateTime |
| Id | RadzenId |
| Link | RadzenLink |
| Number | RadzenNumber |
| Password | RadzenPassword |
| RadioButton | RadzenRadioButton |
| RadioGroup | RadzenRadioGroup |
| Select | RadzenSelect |
| Text | RadzenText |
| Time | RadzenTime |

## カスタムコントロール

このライブラリでは次の2個のカスタムコントロールが提供されています。

- RadzenChart

## RadzenChart

データをグラフで表示するためのコントロールです。

![image](https://github.com/user-attachments/assets/f96e2de1-8c9e-40d3-8a5b-224036e0ec28)
