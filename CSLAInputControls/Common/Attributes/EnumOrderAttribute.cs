using System;

namespace CSLAInputControls.Common.Attributes
{
    public class EnumOrderAttribute : Attribute
    {
        public EnumOrderAttribute(int order)
        {
            Order = order;
        }

        public int Order { get; }
    }
}
