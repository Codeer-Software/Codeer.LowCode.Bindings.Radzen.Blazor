using Codeer.LowCode.Blazor.Components;
using Codeer.LowCode.Blazor.OperatingModel;
using Codeer.LowCode.Blazor.Repository.Design;

namespace Codeer.LowCode.Bindings.Radzen.Blazor.Infrastructure
{
    public class RadzenFieldComponentBase<T, TRadzen> : FieldComponentBase<T>
        where T : FieldBase where TRadzen : FieldDesignBase
    {
        protected TRadzen RadzenDesign => (TRadzen)Field.Design;
    }
}
