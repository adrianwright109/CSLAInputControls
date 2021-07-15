﻿using MB5.Common.Constants;
using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaDateTimePickerBase<TPropertyValueType> : CslaDateAndDateTimePickerBase<TPropertyValueType>
    {
        [Parameter]
        public override string Format { get; set; } = Constants.DefaultDateTimeFormat;
    }
}
