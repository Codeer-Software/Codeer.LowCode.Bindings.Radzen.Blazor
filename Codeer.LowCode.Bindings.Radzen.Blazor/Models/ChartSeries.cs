namespace Codeer.LowCode.Bindings.Radzen.Blazor.Models
{
    public class ChartSeries
    {
        public string Name { get; set; } = string.Empty;
        public double[] Data { get; set; } = [];

        public IEnumerable<ChartItem> AsItems(List<string> labels) => Data.Select((value, index) => new ChartItem
        {
            Label = labels.ElementAtOrDefault(index) ?? string.Empty,
            Value = value
        });
    }
}
