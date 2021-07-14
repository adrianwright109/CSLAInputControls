using System;
using System.ComponentModel.DataAnnotations;

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum FunctionLogType
    {
        [Display(Name = "Apply Maintbook File Started")]
        ApplyMaintbookFileStarted = 1,
        [Display(Name = "Apply Maintbook File Ended")]
        ApplyMaintbookFileEnded = 2,

        [Display(Name = "Accept Modified Manufacturers Started")]
        AcceptModifiedManufacturersStarted = 3,
        [Display(Name = "Accept Modified Manufacturers Ended")]
        AcceptModifiedManufacturersEnded = 4,
        [Display(Name = "Accept Modified Tyres Started")]
        AcceptModifiedTyresStarted = 5,
        [Display(Name = "Accept Modified Tyres Ended")]
        AcceptModifiedTyresEnded = 6,

        [Display(Name = "Accept New Vehicles Started")]
        AcceptNewVehiclesStarted = 7,
        [Display(Name = "Accept New Vehicles Ended")]
        AcceptNewVehiclesEnded = 8,
        [Display(Name = "Accept Modified Vehicles Started")]
        AcceptModifiedVehiclesStarted = 9,
        [Display(Name = "Accept Modified Vehicles Ended")]
        AcceptModifiedVehiclesEnded = 10,

        [Display(Name = "Chart Custom Categories")]
        ChartCustomCategories = 11,
        [Display(Name = "Chart Income Cashflow")] 
        ChartIncomeCashflow = 12,

        [Display(Name = "CashFlow Started")] 
        CashFlowStarted = 13,
        [Display(Name = "CashFlow Ended")] 
        CashFlowEnded = 14,

        [Display(Name = "Client Reset Password")] 
        ClientResetPassword = 15,

        [Display(Name = "FleetWare Matrix Started")]
        FleetWareMatrixStarted = 16,
        [Display(Name = "FleetWare Matrix Ended")]
        FleetWareMatrixEnded = 17,
        [Display(Name = "FleetWare Compare Started")]
        FleetWareCompareStarted = 18,
        [Display(Name = "FleetWare Compare Ended")]
        FleetWareCompareEnded = 19,

        [Display(Name = "Import Maintbook File Started")]
        ImportMaintbookFileStarted = 20,
        [Display(Name = "Import Maintbook File Ended")]
        ImportMaintbookFileEnded = 21,

        [Display(Name = "Load Settings Group")] 
        LoadSettingsGroup = 22,
        [Display(Name = "Save Settings Group")] 
        SaveSettingsGroup = 23,

        [Display(Name = "Matrix Started")] 
        MatrixStarted = 24,
        [Display(Name = "Matrix Ended")] 
        MatrixEnded = 25,

        [Display(Name = "Parameter Started")] 
        ParameterStarted = 26,
        [Display(Name = "Parameter Ended")] 
        ParameterEnded = 27,

        [Display(Name = "SMR Audit Upload Started")]
        SMRAuditUploadStarted = 28,
        [Display(Name = "SMR Audit Upload Ended")]
        SMRAuditUploadEnded = 29,
        [Display(Name = "SMR Audit Validate Started")]
        SMRAuditValidateStarted = 30,
        [Display(Name = "SMR Audit Validate Ended")]
        SMRAuditValidateEnded = 31,
        [Display(Name = "SMR Audit Download Started")]
        SMRAuditDownloadStarted = 32,
        [Display(Name = "SMR Audit Download Ended")]
        SMRAuditDownloadEnded = 33,

        [Display(Name = "Snapshot Load Started")] 
        SnapshotLoadStarted = 34,
        [Display(Name = "Snapshot Load Ended")] 
        SnapshotLoadEnded = 35,
        [Display(Name = "Snapshot Save Started")] 
        SnapshotSaveStarted = 36,
        [Display(Name = "Snapshot Save Ended")] 
        SnapshotSaveEnded = 37,

        [Display(Name = "Upload Maintbook File Started")]
        UploadMaintbookFileStarted = 38,
        [Display(Name = "Upload Maintbook File Ended")]
        UploadMaintbookFileEnded = 39,

        [Display(Name = "User Parameter Load Validate Started")]
        UserParameterLoadValidateStarted = 40,
        [Display(Name = "User Parameter Load Validate Ended")]
        UserParameterLoadValidateEnded = 41,

        [Display(Name = "User Parameter Load Validate Results")]
        UserParameterLoadValidateResults = 42,

        [Display(Name = "User Parameter Load Apply Started")]
        UserParameterLoadApplyStarted = 43,
        [Display(Name = "User Parameter Load Apply Ended")]
        UserParameterLoadApplyEnded = 44,

        [Display(Name = "GetSMRVehicleDetails Started")]
        GetSMRVehicleDetailsStarted = 45,
        [Display(Name = "GetSMRVehicleDetails Invalid KeyCode")]
        GetSMRVehicleDetailsInvalidKeyCode = 46,
        [Display(Name = "GetSMRVehicleDetails Vehicle Not Found")]
        GetSMRVehicleDetailsVehicleNotFound = 47,
        [Display(Name = "GetSMRVehicleDetails Ended")]
        GetSMRVehicleDetailsEnded = 48,

        [Display(Name = "View Cashflow for Vehicle")]
        ViewCashflowForVehicle = 49,

        [Display(Name = "Validate Maintbook File Started")]
        ValidateMaintbookFileStarted = 50,
        [Display(Name = "Validate Maintbook File Ended")]
        ValidateMaintbookFileEnded = 51,

        [Display(Name = "Export Vehicle Categories Started")]
        ExportVehicleCategoriesStarted = 52,
        [Display(Name = "Export Vehicle Categories Ended")]
        ExportVehicleCategoriesEnded = 53,

        [Display(Name = "Export Vehicle List Started")]
        ExportVehicleListStarted = 54,
        [Display(Name = "Export Vehicle List Ended")]
        ExportVehicleListEnded = 55
    }
}
