using Microsoft.AspNetCore.Components;

namespace MB5.Client.Shared
{
    public class CslaNumericInputBase<TPropertyValueType> : CslaInputBase<TPropertyValueType>
    {
        [Parameter]
        public bool? BoldCondition { get; set; }

        [Parameter]
        public override string Format { get; set; } = "N0";

        [Parameter]
        public TPropertyValueType Min { get; set; }

        [Parameter]
        public TPropertyValueType Max { get; set; }

        [Parameter]
        public TPropertyValueType Step { get; set; }

        [Parameter]
        public int Decimals { get; set; }

        [Parameter]
        public bool Arrows { get; set; } = true;

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
    }
}
