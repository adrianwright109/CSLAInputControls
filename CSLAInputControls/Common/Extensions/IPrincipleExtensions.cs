using System.Security.Principal;
using CSLAInputControls.Common.Enums;

namespace CSLAInputControls.Common.Extensions
{
    public static class IPrincipleExtensions
    {
        public static bool IsInUserRole(this IPrincipal principal, UserRole userRole)
        {
            return principal.IsInRole(userRole.ToString());
        }
    }
}
