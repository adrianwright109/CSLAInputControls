using System;
using CSLAInputControls.Common.Enums;

namespace CSLAInputControls.Common.Extensions
{
    public static class AccessLogTypeExtensions
    {
        public static string To2LetterCode(this AccessLogType logType)
        {
            switch (logType)
            {
                case AccessLogType.LoggedIn:
                    return "OK";
                case AccessLogType.Requires2FA:
                    return "2F";
                case AccessLogType.UserAccountLockedOut:
                    return "AL";
                case AccessLogType.FailedLogin:
                    return "FL";
                case AccessLogType.UsernameDoesNotExist:
                    return "NO";
                case AccessLogType.UserIdDoesNotExist:
                    return "UI";
                case AccessLogType.ClientIdDoesNotExist:
                    return "CI";
                case AccessLogType.ClientIsLocked:
                    return "CL";
                case AccessLogType.UserAccountIsInactivated:
                    return "IU";
                case AccessLogType.UserAccountIsDeleted:
                    return "UX";
                case AccessLogType.NewSession:
                    return "NS";
                case AccessLogType.ResumeSession:
                    return "RS";
                case AccessLogType.LoggedOut:
                    return "LO";
                default:
                    throw new ArgumentOutOfRangeException(nameof(logType), logType, null);
            }
        }
    }
}
