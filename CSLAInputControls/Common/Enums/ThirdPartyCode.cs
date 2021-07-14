using System;
using CSLAInputControls.Common.Attributes;

// ReSharper disable InconsistentNaming

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum ThirdPartyCode
    {
        [EnumOrder(1)]
        CAR_CAP = 1,

        [EnumOrder(2)]
        CAR_CAPiD = 2,

        [EnumOrder(3)]
        CAR_EDI = 3,

        [EnumOrder(4)]
        CAR_Fleetnet = 4,

        [EnumOrder(5)]
        CAR_KCAPid = 11,

        [EnumOrder(6)]
        CAR_KeeCode = 10,

        [EnumOrder(7)]
        CAR_KWIKid = 9,

        [EnumOrder(8)]
        LCV_CAP = 5,

        [EnumOrder(9)]
        LCV_CAPiD = 6,

        [EnumOrder(10)]
        LCV_EDI = 7,

        [EnumOrder(11)]
        LCV_Fleetnet = 8,

        [EnumOrder(12)]
        LCV_KCAPid = 14,

        [EnumOrder(13)]
        LCV_KeeCode = 13,

        [EnumOrder(14)]
        LCV_KWIKid = 12
    }
}
