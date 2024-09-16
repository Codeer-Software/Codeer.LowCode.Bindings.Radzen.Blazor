using Codeer.LowCode.Bindings.Radzen.Blazor.Components;
using Codeer.LowCode.Bindings.Radzen.Blazor.Enums;
using Codeer.LowCode.Bindings.Radzen.Blazor.Fields;
using Codeer.LowCode.Blazor.DesignLogic;
using Codeer.LowCode.Blazor.DesignLogic.Check;
using Codeer.LowCode.Blazor.DesignLogic.Refactor;
using Codeer.LowCode.Blazor.OperatingModel;
using Codeer.LowCode.Blazor.Repository.Data;
using Codeer.LowCode.Blazor.Repository.Design;
using Codeer.LowCode.Blazor.Repository.Match;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Designs
{
    public class RadzenChartFieldDesign() : FieldDesignBase(typeof(RadzenChartFieldDesign).FullName!), IDisplayName,
        ISearchResultsViewFieldDesign
    {
        [Designer(Scope = DesignerScope.All)]
        public SearchCondition SearchCondition { get; set; } = new();

        [Designer]
        public string DisplayName { get; set; } = string.Empty;

        [Designer]
        public string Height { get; set; } = "500px";

        [Designer]
        public RadzenChartType ChartType { get; set; } = RadzenChartType.Line;

        [Designer]
        public bool IsSmooth { get; set; } = true;

        [Designer]
        public bool ShowLegend { get; set; } = true;

        [Designer]
        public bool XAxisLines { get; set; } = true;

        [Designer]
        public bool YAxisLines { get; set; } = true;
        
        [Designer(CandidateType = CandidateType.Field)]
        public string CategoryField { get; set; } = string.Empty;

        public override string GetWebComponentTypeFullName() => typeof(RadzenChartFieldComponent).FullName!;

        public override string GetSearchWebComponentTypeFullName() => string.Empty;

        public override string GetSearchControlTypeFullName() => string.Empty;

        public override FieldBase CreateField() => new RadzenChartField(this);

        public override FieldDataBase? CreateData() => null;

        public override List<DesignCheckInfo> CheckDesign(DesignCheckContext context)
        {
            var result = base.CheckDesign(context);
            result.AddRange(SearchCondition.CheckDesign(context, Name, nameof(SearchCondition)));
            return result;
        }

        public override RenameResult ChangeName(RenameContext context) => context.Builder(base.ChangeName(context))
            .AddMatchCondition(SearchCondition)
            .Build();
    }
}
