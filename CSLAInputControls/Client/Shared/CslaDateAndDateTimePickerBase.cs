using System;
using Microsoft.AspNetCore.Components;
using ServiceStack;

namespace MB5.Client.Shared
{
    public abstract class CslaDateAndDateTimePickerBase<TModelProperty> : CslaInputBase
    {
        [Parameter]
        public DateTime Min { get; set; } = DateTime.MinValue;

        [Parameter]
        public DateTime Max { get; set; } = DateTime.MaxValue;

        [Parameter]
        public override string Format { get; set; }

        [Parameter]
        public string Width { get; set; } = "100%";

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