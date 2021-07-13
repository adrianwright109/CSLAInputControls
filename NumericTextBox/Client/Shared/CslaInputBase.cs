using Csla.Blazor;
using Microsoft.AspNetCore.Components;

namespace NumericTextBox.Client.Shared
{
    public class CslaInputBase : ComponentBase
    {
        private const string _onInputEventName = "oninput";
        private const string _onChangeEventName = "onchange";

        private bool _bindPropertyAndValidationOnInput = true;
        private bool _showLabel = true;
        private string _extraLabelText = "";
        private bool _prefixExtraLabelText = false;
        private string _format;
        protected string BindEvent = _onInputEventName;

        [Parameter]
        public IPropertyInfo Property { get; set; }

        [Parameter]
        public bool BindPropertyAndValidationOnInput
        {
            get => _bindPropertyAndValidationOnInput;
            set
            {
                _bindPropertyAndValidationOnInput = value;
                BindEvent = _bindPropertyAndValidationOnInput ? _onInputEventName : _onChangeEventName;
            }
        }

        [Parameter]
        public bool ShowLabel 
        { 
            get => _showLabel; 
            set => _showLabel = value; 
        }

        [Parameter]
        public string ExtraLabelText
        {
            get => _extraLabelText;
            set => _extraLabelText = value;
        }

        [Parameter]
        public bool PreFixExtraLabelText
        {
            get => _prefixExtraLabelText;
            set => _prefixExtraLabelText = value;
        }

        [Parameter]
        public string Format
        {
            get => _format;
            set => _format = value;
        }
    }

    public class CslaGenericInputBase<TModelProperty> : ComponentBase
    {
        private const string _onInputEventName = "oninput";
        private const string _onChangeEventName = "onchange";

        private bool _bindPropertyAndValidationOnInput = true;
        private bool _showLabel = true;
        protected string BindEvent = _onInputEventName;

        [Parameter]
        public IPropertyInfo Property { get; set; }

        [Parameter]
        public bool BindPropertyAndValidationOnInput
        {
            get => _bindPropertyAndValidationOnInput;
            set
            {
                _bindPropertyAndValidationOnInput = value;
                BindEvent = _bindPropertyAndValidationOnInput ? _onInputEventName : _onChangeEventName;
            }
        }

        [Parameter]
        public bool ShowLabel
        {
            get => _showLabel;
            set => _showLabel = value;
        }
    }
}
