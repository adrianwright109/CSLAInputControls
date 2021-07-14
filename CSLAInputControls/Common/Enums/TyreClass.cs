using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum TyreClass
    {
        [EnumOrder(1)]
        [Display(Name = "Premium")]
        Premium = 'P',

        [EnumOrder(2)]
        [Display(Name = "Budget")]
        Budget = 'B'
    }
}
