# Component Mapping - Radzen vs Standard

## Field Components

| Standard Component | Radzen Component | Design Class | Search Component |
|---|---|---|---|
| TextFieldComponent | RadzenTextFieldComponent | RadzenTextFieldDesign | RadzenTextComponent |
| NumberFieldComponent | RadzenNumberFieldComponent | RadzenNumberFieldDesign | RadzenNumberComponent |
| BooleanFieldComponent | RadzenBooleanFieldComponent | RadzenBooleanFieldDesign | RadzenBooleanComponent |
| DateFieldComponent | RadzenDateFieldComponent | RadzenDateFieldDesign | RadzenDateComponent |
| DateTimeFieldComponent | RadzenDateTimeFieldComponent | RadzenDateTimeFieldDesign | RadzenDateTimeComponent |
| TimeFieldComponent | RadzenTimeFieldComponent | RadzenTimeFieldDesign | RadzenTimeComponent |
| ButtonFieldComponent | RadzenButtonFieldComponent | RadzenButtonFieldDesign | - |
| SubmitButtonFieldComponent | RadzenSubmitButtonFieldComponent | RadzenSubmitButtonFieldDesign | - |
| LinkFieldComponent | RadzenLinkFieldComponent | RadzenLinkFieldDesign | RadzenLinkComponent |
| SelectFieldComponent | RadzenSelectFieldComponent | RadzenSelectFieldDesign | RadzenSelectComponent |
| IdFieldComponent | RadzenIdFieldComponent | RadzenIdFieldDesign | - |
| RadioGroupFieldComponent | RadzenRadioGroupFieldComponent | RadzenRadioGroupFieldDesign | RadzenRadioGroupComponent |
| RadioButtonFieldComponent | RadzenRadioButtonFieldComponent | RadzenRadioButtonFieldDesign | - |
| PasswordFieldComponent | RadzenPasswordFieldComponent | RadzenPasswordFieldDesign | - |
| FileFieldComponent | RadzenFileFieldComponent | RadzenFileFieldDesign | RadzenFileComponent |
| LabelFieldComponent | *未実装* | - | - |
| AnchorTagFieldComponent | *未実装* | - | - |

## Radzen 独自コンポーネント

| Radzen Component | Design Class | Description |
|---|---|---|
| RadzenChartFieldComponent | RadzenChartFieldDesign | グラフ表示 (棒/線/円グラフ等) |

## Radzen UI コンポーネントの対応

| 標準 (Bootstrap) | Radzen |
|---|---|
| `<input type="text">` | `<RadzenTextBox>` |
| `<textarea>` | `<RadzenTextArea>` |
| `<input type="number">` | `<RadzenNumeric>` |
| `<input type="range">` | `<RadzenSlider>` |
| `<input type="checkbox">` | `<RadzenCheckBox>` |
| `<input type="radio">` | `<RadzenRadioButtonList>` |
| `<select>` | `<RadzenDropDown>` |
| `<input type="date">` | `<RadzenDatePicker>` |
| `<input type="datetime-local">` | `<RadzenDatePicker ShowTime="true">` |
| `<input type="time">` | `<RadzenDatePicker ShowTime="true" TimeOnly="true">` |
| `<input type="password">` | `<RadzenPassword>` |
| `<button>` | `<RadzenButton>` |
| Toggle button | `<RadzenToggleButton>` |
| Switch | `<RadzenSwitch>` |
| Stack layout | `<RadzenStack>` |
| Form field wrapper | `<RadzenFormField>` |

## 内部ヘルパーコンポーネント

| Component | Location | Description |
|---|---|---|
| Validator | Internal/Components/Validator.razor | バリデーションメッセージ表示 |
| MatchConditionDropdown | Internal/MatchConditionDropdown.razor | 検索比較条件ドロップダウン |
