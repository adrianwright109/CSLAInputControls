using System;
using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public abstract class CslaDateAndDateTimePickerBase<TPropertyValueType> : CslaInputBase<TPropertyValueType>
    {
        [Parameter]
        public DateTime Min { get; set; } = DateTime.MinValue;

        [Parameter]
        public DateTime Max { get; set; } = DateTime.MaxValue;

        [Parameter]
        public override string Format { get; set; }
    }
}