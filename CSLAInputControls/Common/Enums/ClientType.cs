using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum ClientType
    {
        [EnumOrder(1)]
        [Display(Name = "Fleet")]
        Fleet = 1,

        [EnumOrder(2)]
        [Display(Name = "Manufacturer")]
        Manufacturer = 2,

        [EnumOrder(3)]
        [Display(Name = "Manufacturer (Restricted)")]
        ManufacturerRestricted = 3,

        [EnumOrder(4)]
        [Display(Name = "Other")]
        Other = 4
    }
}
