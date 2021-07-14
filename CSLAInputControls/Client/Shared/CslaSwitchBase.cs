using Microsoft.AspNetCore.Components;
using ServiceStack;

namespace CSLAInputControls.Client.Shared
{
    public abstract class CslaSwitchBase<TModelProperty> : CslaInputBase
    {
        [Parameter]
        public string OnLabel { get; set; } = " ";

        [Parameter]
        public string OffLabel { get; set; } = " ";

        [Parameter]
        public string Width { get; set; } = "60px";

        protected TModelProperty Value
        {
            get => Property.Value != null ? (TModelProperty)Property.Value : default;
            // ReSharper disable once UnusedMember.Global
            set
            {
                var defaultValueForModelProperty = default(TModelProperty);

                if (!Equals(value, defaultValueForModelProperty))
                {
                    SetNewValue(value);
                }
                else
                {
                    if (!typeof(TModelProperty).IsNullableType())
                    {
                        SetNewValue(default);
                    }
                    else
                    {
                        Property.Value = null;
                    }
                }
            }
        }

        private void SetNewValue(TModelProperty newValue)
        {
            Property.Value = newValue;
        }
    }
}