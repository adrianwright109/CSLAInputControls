using System;
using System.ComponentModel.DataAnnotations;

// ReSharper disable InconsistentNaming

namespace CSLAInputControls.Common.Enums
{
    [Serializable]
    public enum AccessLogType
    {
        [Display(Name = "Logged In")]
        LoggedIn = 1,

        [Display(Name = "Requires two factor authentication")]
        Requires2FA = 2,

        [Display(Name = "User account locked out")]
        UserAccountLockedOut = 3,

        [Display(Name = "Failed login")]
        FailedLogin = 4,

        [Display(Name = "Username does not exist")]
        UsernameDoesNotExist = 5,

        [Display(Name = "UserId does not exist")]
        UserIdDoesNotExist = 6,

        [Display(Name = "ClientId does not exist")]
        ClientIdDoesNotExist = 7,

        [Display(Name = "Client is Locked")] 
        ClientIsLocked = 8,

        [Display(Name = "User Account is Inactivated")]
        UserAccountIsInactivated = 9,

        [Display(Name = "User Account is Deleted")]
        UserAccountIsDeleted = 10,

        [Display(Name = "New Session")]
        NewSession = 11,

        [Display(Name = "Resume Session")]
        ResumeSession = 12,

        [Display(Name = "Logged Out")]
        LoggedOut = 13
    }
}
