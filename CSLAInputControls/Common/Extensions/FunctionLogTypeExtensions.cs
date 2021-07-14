using System;
using CSLAInputControls.Common.Enums;

namespace CSLAInputControls.Common.Extensions
{
    public static class FunctionLogTypeExtensions
    {
        public static string To2LetterCode(this FunctionLogType logType)
        {
            switch (logType)
            {
                case FunctionLogType.ApplyMaintbookFileStarted:
                    return "AS";
                case FunctionLogType.ApplyMaintbookFileEnded:
                    return "AE";
                case FunctionLogType.AcceptModifiedManufacturersStarted:
                    return "AM";
                case FunctionLogType.AcceptModifiedManufacturersEnded:
                    return "AN";
                case FunctionLogType.AcceptModifiedTyresStarted:
                    return "AT";
                case FunctionLogType.AcceptModifiedTyresEnded:
                    return "AU";
                case FunctionLogType.AcceptNewVehiclesStarted:
                    return "AV";
                case FunctionLogType.AcceptNewVehiclesEnded:
                    return "AW";
                case FunctionLogType.AcceptModifiedVehiclesStarted:
                    return "AX";
                case FunctionLogType.AcceptModifiedVehiclesEnded:
                    return "AY";
                case FunctionLogType.ChartCustomCategories:
                    return "CC";
                case FunctionLogType.ChartIncomeCashflow:
                    return "CI";
                case FunctionLogType.CashFlowStarted:
                    return "CS";
                case FunctionLogType.CashFlowEnded:
                    return "CE";
                case FunctionLogType.ClientResetPassword:
                    return "CP";
                case FunctionLogType.FleetWareMatrixStarted:
                    return "FS";
                case FunctionLogType.FleetWareMatrixEnded:
                    return "FE";
                case FunctionLogType.FleetWareCompareStarted:
                    return "F1";
                case FunctionLogType.FleetWareCompareEnded:
                    return "F2";
                case FunctionLogType.ImportMaintbookFileStarted:
                    return "IS";
                case FunctionLogType.ImportMaintbookFileEnded:
                    return "IE";
                case FunctionLogType.LoadSettingsGroup:
                    return "LS";
                case FunctionLogType.SaveSettingsGroup:
                    return "LT";
                case FunctionLogType.MatrixStarted:
                    return "MS";
                case FunctionLogType.MatrixEnded:
                    return "ME";
                case FunctionLogType.ParameterStarted:
                    return "PS";
                case FunctionLogType.ParameterEnded:
                    return "PE";
                case FunctionLogType.SMRAuditUploadStarted:
                    return "SS";
                case FunctionLogType.SMRAuditUploadEnded:
                    return "SE";
                case FunctionLogType.SMRAuditValidateStarted:
                    return "S1";
                case FunctionLogType.SMRAuditValidateEnded:
                    return "S2";
                case FunctionLogType.SMRAuditDownloadStarted:
                    return "S3";
                case FunctionLogType.SMRAuditDownloadEnded:
                    return "S4";
                case FunctionLogType.SnapshotLoadStarted:
                    return"SL";
                case FunctionLogType.SnapshotLoadEnded:
                    return "SM";
                case FunctionLogType.SnapshotSaveStarted:
                    return"SN";
                case FunctionLogType.SnapshotSaveEnded:
                    return"SO";
                case FunctionLogType.UploadMaintbookFileStarted:
                    return"US";
                case FunctionLogType.UploadMaintbookFileEnded:
                    return"UE";
                case FunctionLogType.UserParameterLoadValidateStarted:
                    return"U1";
                case FunctionLogType.UserParameterLoadValidateEnded:
                    return "U2";
                case FunctionLogType.UserParameterLoadValidateResults:
                    return "U3";
                case FunctionLogType.UserParameterLoadApplyStarted:
                    return "U4";
                case FunctionLogType.UserParameterLoadApplyEnded:
                    return "U5";
                case FunctionLogType.GetSMRVehicleDetailsStarted:
                    return"WC";
                case FunctionLogType.GetSMRVehicleDetailsInvalidKeyCode:
                    return"WI";
                case FunctionLogType.GetSMRVehicleDetailsVehicleNotFound:
                    return"WV";
                case FunctionLogType.GetSMRVehicleDetailsEnded:
                    return"WS";
                case FunctionLogType.ViewCashflowForVehicle:
                    return"VC";
                case FunctionLogType.ValidateMaintbookFileStarted:
                    return"VS";
                case FunctionLogType.ValidateMaintbookFileEnded:
                    return"VE";
                case FunctionLogType.ExportVehicleCategoriesStarted:
                    return"V1";
                case FunctionLogType.ExportVehicleCategoriesEnded:
                    return "V2";
                case FunctionLogType.ExportVehicleListStarted:
                    return "V3";
                case FunctionLogType.ExportVehicleListEnded:
                    return "V4";
                default:
                    throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
            }
        }
    }
}
