using System;
using CSLAInputControls.Common.Attributes;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum FeatureOption
    {
        [EnumOrder(1)]
        SMRMatrix = 1,

        [EnumOrder(2)]
        TyreMatrix = 2,

        [EnumOrder(3)]
        SMRAudit = 3,

        [EnumOrder(4)]
        ParameterOutput = 4,

        [EnumOrder(5)]
        SMRDrillDownOutput = 5,

        [EnumOrder(6)]
        SMRCashflowOutput = 6,

        [EnumOrder(7)]
        UserParameterLoad = 7,

        [EnumOrder(8)]
        ThirdPartyCodeSearcher = 8,

        [EnumOrder(9)]
        SessionSnapshot = 9,

        [EnumOrder(10)]
        VehicleSMRCategoriesExport = 10,

        [EnumOrder(11)]
        VehicleCashFlowIncomeChart = 11,

        [EnumOrder(12)]
        CustomSMRCategoriesCharting = 12,

        [EnumOrder(13)]
        FleetwareOutputMatrix = 13,

        [EnumOrder(14)]
        VehicleHistory = 14,

        [EnumOrder(15)]
        CompareFleetwareToSession = 15
    }
}
