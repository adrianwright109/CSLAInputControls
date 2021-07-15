using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaTextInputBase : CslaInputBase
    {
        [Parameter]
        public string Width { get; set; } = "100%";

        protected string Value
        {
            get => (string)Property.Value;
            set => Property.Value = value;
        }
    }
}
