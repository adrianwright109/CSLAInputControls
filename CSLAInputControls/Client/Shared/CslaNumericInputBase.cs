using Microsoft.AspNetCore.Components;
using ServiceStack;

namespace CSLAInputControls.Client.Shared
{
    public class CslaNumericInputBase<TModelProperty> : CslaInputBase
    {
        [Parameter]
        public string Width { get; set; } = "100%";

        [Parameter]
        public bool? BoldCondition { get; set; }

        [Parameter]
        public override string Format { get; set; } = "N0";

        [Parameter]
        public TModelProperty Min { get; set; }

        [Parameter]
        public TModelProperty Max { get; set; }

        [Parameter]
        public TModelProperty Step { get; set; }

        [Parameter]
        public int Decimals { get; set; }

        [Parameter]
        public bool Arrows { get; set; } = true;

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

        protected string Class
        {
            get
            {
                if (BoldCondition.HasValue && BoldCondition.Value)
                {
                    return "bold";
                }

                return null;
            }
        }

        private void SetNewValue(TModelProperty newValue)
        {
            Property.Value = newValue;
        }
    }
}
