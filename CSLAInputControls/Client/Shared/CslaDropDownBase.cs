using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using ServiceStack;

namespace CSLAInputControls.Client.Shared
{
    public class CslaDropDownBase<TDataItem, TModelProperty> : CslaInputBase
    {
        [Parameter]
        public IEnumerable<TDataItem> Data { get; set; }

        [Parameter]
        public string DefaultText { get; set; } = "Please Select";

        [Parameter]
        public string ValueField { get; set; } = "Key";

        [Parameter]
        public string TextField { get; set; } = "Value";

        [Parameter]
        public string Width { get; set; } = "100%";

        [Parameter]
        public bool Enabled { get; set; } = true;

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
