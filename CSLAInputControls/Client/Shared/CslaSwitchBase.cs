using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public abstract class CslaSwitchBase<TPropertyValueType> : CslaInputBase<TPropertyValueType>
    {
        [Parameter]
        public string OnLabel { get; set; } = " ";

        [Parameter]
        public string OffLabel { get; set; } = " ";

        [Parameter]
        public override string Width { get; set; } = "60px";
    }
}