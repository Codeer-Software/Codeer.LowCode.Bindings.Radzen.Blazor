# Codeer.LowCode.Bindings.Radzen.Blazor - Claude Code Guide

## Overview

Codeer.LowCode.Blazor の拡張 Field ライブラリ。標準の Bootstrap ベースコンポーネントを
Radzen Blazor コンポーネントに置き換える。Chart フィールドなど独自コンポーネントも含む。

- **Version**: 0.5.0
- **Target**: .NET 8.0
- **Base Library**: Codeer.LowCode.Blazor (現在 v1.2.49)
- **UI Library**: Radzen.Blazor (現在 v5.2.9)
- **Standard Library Source** (参照用): `C:\tfs\codeer\Codeer.LowCode.Blazor`

## Architecture

### 3ファイル構成パターン (各フィールド型)

```
Designs/RadzenXxxFieldDesign.cs     → 標準の XxxFieldDesign を継承
Components/RadzenXxxFieldComponent.razor → RadzenFieldComponentBase<TField, TDesign> を継承
Search/RadzenXxxComponent.razor     → 検索用コンポーネント (該当する型のみ)
```

### Design クラスの実装パターン

```csharp
[IgnoreBaseProperties(nameof(Variant), nameof(ImageResourceSet), nameof(ShowTextInToolTip))]
public class RadzenXxxFieldDesign : XxxFieldDesign
{
    public RadzenXxxFieldDesign() => TypeFullName = typeof(RadzenXxxFieldDesign).FullName!;
    public override string GetWebComponentTypeFullName() => typeof(RadzenXxxFieldComponent).FullName!;
    public override string GetSearchWebComponentTypeFullName() => typeof(RadzenXxxComponent).FullName!;

    [Designer] // Radzen 固有プロパティ
    public RadzenVariant Variant { get; set; }
    [Designer]
    public RadzenColor Color { get; set; }
}
```

### Component の実装パターン

```razor
@inherits RadzenFieldComponentBase<XxxField, RadzenXxxFieldDesign>

@if (IsViewMode) {
  <span class="d-block py-2">@ViewOnlyValue</span>
} else {
  <RadzenTextBox @bind-Value:get="@Value" @bind-Value:set="@OnValueChanged" ... />
  <Validator IsValid="@Field.IsValid" ErrorMessage="@Field.ErrorText" />
}

@code {
  private bool IsDisabled => Field.IsEnabled == false;
  private bool IsViewMode => Field.IsViewOnly;
  // Field.Services.AppInfoService.Localize() でローカライズ
  // Field.Services.AppInfoService.IsDesignMode でデザインモード判定
}
```

## Key Rules

### Localize は public API を使う
```csharp
// NG: Field.Localize() は internal - 外部アセンブリからアクセス不可
// OK:
Field.Services.AppInfoService.Localize(text)
```

### internal メソッドへのアクセス不可
以下は Codeer.LowCode.Blazor の internal メソッドなので直接呼べない:
- `Field.Localize()` → `Field.Services.AppInfoService.Localize()` を使う
- `Field.GetRowCount()` → 自前で計算 (AutoFitRows対応含む)
- `LabelField.IsRequired()` → 関連フィールドを自前で確認するロジックを実装

### RadzenSlider の制約
`RadzenSlider<TValue>` は nullable 型を受け付けない。
`decimal?` → `decimal` に変換してバインドする必要がある。

### ボタンのテキスト
- `ButtonField`: `Field.Text` を使う (スクリプトによる実行時上書きをサポート)
- `SubmitButtonField`: `Field.Design.Text` を使う

### Radzen.Blazor バージョン
現在 v5.2.9。メジャーバージョンアップ (9.x) は破壊的変更が多いため慎重に検討。

## Build

```bash
# ソリューション全体ビルド
dotnet build Codeer.LowCode.Bindings.Radzen.Blazor.sln

# メインライブラリのみ
dotnet build Codeer.LowCode.Bindings.Radzen.Blazor/Codeer.LowCode.Bindings.Radzen.Blazor.csproj
```

NuGet パッケージはビルド時に自動生成 (`GeneratePackageOnBuild: True`)。

## Maintenance Workflow

### 標準ライブラリ更新時の作業手順

1. **NuGet 更新**: `Codeer.LowCode.Blazor` のバージョンを上げる
2. **標準コンポーネントとの差分確認**: 各フィールドの標準実装を読み、変更点を特定
   - 標準コンポーネント: `C:\tfs\codeer\Codeer.LowCode.Blazor\Source\Codeer.LowCode.Blazor\Components\Fields\`
   - 標準検索コンポーネント: `C:\tfs\codeer\Codeer.LowCode.Blazor\Source\Codeer.LowCode.Blazor\Components\Search\`
3. **Design クラスの確認**: 新しいプロパティが追加された場合、`[IgnoreBaseProperties]` の更新要否を確認
4. **ビルド検証**: 全プロジェクトでビルドエラーがないことを確認
5. **Example プロジェクト**: 標準の Example (`C:\tfs\codeer\...\Source\App\`) と差分確認

### 詳細ドキュメント

`MaintenanceDocs/` フォルダに詳細情報あり:
- `ComponentMapping.md` - 全コンポーネントの対応表と実装状況
- `StandardDifferences.md` - 標準との既知の差異・制約事項
- `ProjectStructure.md` - ファイル構成の詳細

## File Layout

```
Codeer.LowCode.Bindings.Radzen.Blazor/
├── _Imports.razor              # グローバル using
├── Components/                 # 17 フィールドコンポーネント (Chart含む)
├── Designs/                    # 16 デザインクラス
├── Search/                     # 10 検索コンポーネント
├── Infrastructure/             # RadzenFieldComponentBase.cs (基底クラス)
├── Internal/                   # DateTimeHelper.cs, MatchConditionDropdown, Validator
├── Enums/                      # RadzenColor, RadzenVariant, RadzenChartType
├── Fields/                     # RadzenChartField.cs (独自フィールド)
├── Models/                     # ChartItem.cs, ChartSeries.cs
├── Installer/                  # RadzenInstaller.razor, RadzenLoader.cs
└── Properties/                 # Resource.resx (ローカライズ)
```

## Unique Components (標準にないもの)

- **RadzenChartField** - グラフ表示 (棒・線・円グラフ等)
  - Design: `RadzenChartFieldDesign.cs`
  - Component: `RadzenChartFieldComponent.razor`
  - Field: `RadzenChartField.cs`
  - Models: `ChartItem.cs`, `ChartSeries.cs`

## Code Style

- C# インデント: 4スペース
- Razor/JSON: 2スペース
- 改行: CRLF
- Nullable: enable
- ImplicitUsings: enable
- コンポーネント内のコードは `@code {}` に記述 (コードビハインド不使用)
