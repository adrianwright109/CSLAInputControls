using Csla.Blazor;
using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaHtmlElementBase : ComponentBase
    {
        [Parameter]
        public IPropertyInfo Property { get; set; }

        [Parameter]
        public virtual string Format { get; set; }

        [Parameter]
        public string ExtraLabelText { get; set; } = "";

        [Parameter]
        public bool PreFixExtraLabelText { get; set; }
    }
}
