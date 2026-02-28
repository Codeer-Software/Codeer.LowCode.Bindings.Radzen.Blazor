# Standard Differences - Radzen Library

## 未実装のコンポーネント

### LabelFieldComponent
標準にはあるが Radzen では未実装。必要に応じて追加が必要。
- ヘッディングスタイル (H1-H6)
- RelativeField のテキスト自動表示
- IsRequired マーク (*)
- クリックハンドラ + cursor:pointer

### AnchorTagFieldComponent
標準にはあるが Radzen では未実装。必要に応じて追加が必要。
- URL/HistoryBack/HistoryForward リンク
- 新しいタブで開く
- アイコン表示
- 画像リソースパス

## internal API の代替実装

### Field.Localize()
```csharp
// internal なので使えない → public API で代替
Field.Services.AppInfoService.Localize(text)
```

### Field.GetRowCount()
```csharp
// internal なので使えない → 自前実装
private int GetRowCount() {
    if (!Field.Design.IsAutoFitRows) return Field.Design.Rows ?? 3;
    var rows = Field.Design.Rows ?? 1;
    var lineCount = Field.Value?.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).Length ?? 1;
    return Math.Max(rows, lineCount);
}
```

### LabelField.IsRequired()
internal メソッド。関連フィールドの Design.IsRequired を直接チェックする必要がある。
(Radzen では LabelField 自体が未実装のため現時点では不要)

## Radzen 固有のデザインプロパティ

### RadzenVariant (enum)
Radzen コンポーネントの見た目バリアント。
`.ToVariant()` 拡張メソッドで Radzen.Variant に変換。

### RadzenColor (enum)
ボタン等の色設定。
`.ToButtonStyle()` 拡張メソッドで Radzen.ButtonStyle に変換。

## IgnoreBaseProperties 設定

| Design Class | 非表示にしたプロパティ |
|---|---|
| RadzenButtonFieldDesign | Variant, ImageResourceSet, ShowTextInToolTip |
| RadzenSubmitButtonFieldDesign | ImageResourceSet |

Radzen UI では Bootstrap の Variant や画像リソースセットが使えないため非表示。

## RadzenSlider の制約

`RadzenSlider<TValue>` は `INumber<T>` 制約があり、nullable 型 (`decimal?`) を受け付けない。
`decimal SliderValue => Field.Value ?? 0` のように非 nullable に変換する。

## FileField API

v1.2.49 で `SetFile` → `SetFileAsync` に変更。`UploadFile` は internal。
```csharp
await Field.SetFileAsync(e.File.Name, new StreamContent(file.OpenReadStream(maxAllowedSize)));
```

## DateField IsYearMonthOnly

RadzenDatePicker は月のみモードをサポートしないため、
`<input type="month">` にフォールバックする実装。

## SelectField の OnFocus ハンドラ

`OnAfterRenderAsync` で毎回 `OnFocusAsync()` を呼ぶ実装。
初回レンダリング時に選択肢が更新された場合のバグ回避。

## LinkField の ModalBase Title

現在 "検索" がハードコードされている。ローカライズが必要な場合は Resource ファイルに移動すべき。
