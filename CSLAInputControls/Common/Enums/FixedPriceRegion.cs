// ReSharper disable InconsistentNaming

using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum FixedPriceRegion
    {
        [EnumOrder(1)]
        [Display(Name = "National Average")]
        NationalAverage = 0,

        [EnumOrder(2)]
        [Display(Name = "Region 1")]
        Region1 = 1,

        [EnumOrder(3)]
        [Display(Name = "Region 2")]
        Region2 = 2,

        [EnumOrder(4)]
        [Display(Name = "Region 3")]
        Region3 = 3,

        [EnumOrder(5)]
        [Display(Name = "Region 4")]
        Region4 = 4,

        [EnumOrder(6)]
        [Display(Name = "Region 5")]
        Region5 = 5,

        [EnumOrder(7)]
        [Display(Name = "Region 6")]
        Region6 = 6
    }
}
