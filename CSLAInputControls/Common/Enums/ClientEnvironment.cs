// ReSharper disable InconsistentNaming

using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum ClientEnvironment
    {
        [EnumOrder(1)]
        [Display(Name = "CAR")]
        CAR = 1,

        [EnumOrder(2)]
        [Display(Name = "LCV")]
        LCV = 2
    }
}
