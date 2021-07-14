using Csla.Blazor;
using Microsoft.AspNetCore.Components;

namespace CSLAInputControls.Client.Shared
{
    public class CslaInputBase : ComponentBase
    {
        private const string OnInputEventName = "oninput";
        private const string OnChangeEventName = "onchange";

        private bool _bindPropertyAndValidationOnInput = true;
        protected string BindEvent = OnInputEventName;

        [Parameter]
        public IPropertyInfo Property { get; set; }

        [Parameter]
        public bool BindPropertyAndValidationOnInput
        {
            get => _bindPropertyAndValidationOnInput;
            set
            {
                _bindPropertyAndValidationOnInput = value;
                BindEvent = _bindPropertyAndValidationOnInput ? OnInputEventName : OnChangeEventName;
            }
        }

        [Parameter]
        public bool ShowLabel { get; set; } = true;

        [Parameter]
        public string ExtraLabelText { get; set; } = "";

        [Parameter]
        public bool PreFixExtraLabelText { get; set; }

        [Parameter]
        public virtual string Format { get; set; }
    }
}
