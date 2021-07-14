using System.Linq;
using CSLAInputControls.Common.Enums;
using Microsoft.AspNetCore.Authorization;

namespace CSLAInputControls.Common.Attributes
{
    public class AuthoriseByUserRolesAttribute : AuthorizeAttribute
    {
        public AuthoriseByUserRolesAttribute(params UserRole[] userRoles)
        {
            if (userRoles.Length > 0)
            {
                Roles = string.Join(',', userRoles.Select(x => x.ToString()));
            }
        }
    }
}
