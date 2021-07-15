using System.Collections.Generic;
using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaDropDownBase<TDataItem, TPropertyValueType> : CslaInputBase<TPropertyValueType>
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
        public bool Enabled { get; set; } = true;
    }
}
