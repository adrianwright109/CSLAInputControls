using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum ManufacturerDepot
    {
        [EnumOrder(1)]
        [Display(Name = "Manufacturer")]
        Premium = 'M',

        [EnumOrder(2)]
        [Display(Name = "Depot")]
        Budget = 'D'
    }
}