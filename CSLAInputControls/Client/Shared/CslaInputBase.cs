using Csla.Blazor;
using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaInputBase<TPropertyValueType> : CslaHtmlElementBase
    {
        private const string OnInputEventName = "oninput";
        private const string OnChangeEventName = "onchange";

        private bool _bindPropertyAndValidationOnInput = true;
        protected string BindEvent = OnInputEventName;

        [Parameter]
        public EventCallback<TPropertyValueType> PropertyChanged { get; set; }

        protected TPropertyValueType BoundValue
        {
            get => (TPropertyValueType)Property.Value;
            set
            {
                if (Property.Value == (object)value)
                {
                    //value not changed
                    return;
                }

                Property.Value = value;
                PropertyChanged.InvokeAsync(value);
            }
        }

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
        public virtual string Width { get; set; } = "100%";
    }
}
