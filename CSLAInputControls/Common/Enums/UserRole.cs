using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum UserRole
    {
        [EnumOrder(1)]
        [Display(Name = "Admin User")]
        AdminUser = 'A',

        [EnumOrder(2)]
        [Display(Name = "Standard User")]
        StandardUser = 'U',

        [EnumOrder(3)]
        [Display(Name = "Read-Only User")]
        ReadOnlyUser = 'R'
    }
}
