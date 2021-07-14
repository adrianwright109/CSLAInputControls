using Microsoft.AspNetCore.Components;
using Constants = CSLAInputControls.Common.Constants.Constants;

namespace CSLAInputControls.Client.Shared
{
    public class CslaDateTimePickerBase<TModelProperty> : CslaDateAndDateTimePickerBase<TModelProperty>
    {
        [Parameter]
        public override string Format { get; set; } = Constants.DefaultDateTimeFormat;
    }
}
