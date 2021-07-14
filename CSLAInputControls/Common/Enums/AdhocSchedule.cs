using System;
using System.ComponentModel.DataAnnotations;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum AdhocSchedule
    {
        [EnumOrder(1)]
        [Display(Name = "Start")]
        Start = 'S',

        [EnumOrder(2)]
        [Display(Name = "End")]
        End = 'E',

        [EnumOrder(3)]
        [Display(Name = "Periodic")]
        Periodic = 'P'
    }
}
