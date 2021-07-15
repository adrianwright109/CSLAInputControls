using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaTextInputBase : CslaInputBase<string>
    {
        private const string DefaultPasswordInput = "password";
        private string _inputMode = "text";
        private bool _isPassword;

        [Parameter]
        public string InputType
        {
            get => _inputMode;
            set
            {
                if (value == DefaultPasswordInput)
                {
                    _inputMode = value;
                    _isPassword = true;
                }
                else
                {
                    _inputMode = value;
                    _isPassword = false;
                }
            }
        }

        [Parameter]
        public bool IsPassword
        {
            get => _isPassword;
            set
            {
                if (value)
                {
                    _isPassword = true;
                    _inputMode = DefaultPasswordInput;
                }
                else
                {
                    _isPassword = false;
                }
            }
        }
    }
}
