using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum UserStatus
    {
        [EnumOrder(1)]
        [Display(Name = "Active")]
        Active = 'A',

        [EnumOrder(2)]
        [Display(Name = "Inactive")]
        Inactive = 'I',

        [EnumOrder(3)]
        [Display(Name = "Deleted")]
        Deleted = 'D'
    }
}
