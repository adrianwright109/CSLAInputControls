using System.Linq;
using System.Security.Claims;
using Csla;
using CSLAInputControls.Common.Enums;
using CSLAInputControls.Common.Extensions;

namespace CSLAInputControls.Common.Helpers
{
    public static class AuthHelper
    {
        public static bool IsInUserRole(UserRole userRole)
        {
            if (UserIsAuthenticated())
            {
                ApplicationContext.User.IsInUserRole(userRole);
            }

            return false;
        }

        public static bool UserIsAuthenticated()
        {
            if (ApplicationContext.User != null && ApplicationContext.User.Identity != null)
            {
                return ApplicationContext.User.Identity.IsAuthenticated;
            }

            return false;
        }

        /// <summary>
        /// Get the Maintbook User Id.
        /// NOTE: Use this one Server-side.
        /// </summary>
        /// <returns></returns>
        public static int GetUserIdOnServer()
        {
            if (!UserIsAuthenticated())
            {
                System.Diagnostics.Debug.WriteLine("*** AuthHelper.GetUserID returning 0 as UserIsAuthenticated is false ***");
                return 0;
            }

            var claimsIdentity = (ClaimsIdentity)Csla.ApplicationContext.User.Identity;
            var userId = claimsIdentity.Claims.Where(p => p.Type == "UserId").FirstOrDefault().Value;

            return int.Parse(userId);
        }

        public static int GetClientIdOnServer()
        {
            if (!UserIsAuthenticated())
            {
                System.Diagnostics.Debug.WriteLine("*** AuthHelper.GetClientIdOnServer returning -1 as UserIsAuthenticated is false ***");
                return -1;
            }

            var claimsIdentity = (ClaimsIdentity)Csla.ApplicationContext.User.Identity;
            var clientId = claimsIdentity.Claims.Where(p => p.Type == "ClientId").FirstOrDefault().Value;

            return int.Parse(clientId);
        }

        /// <summary>
        /// Get the Maintbook User Id.
        /// Example use: when in Blazor Client and using AuthState cascading parameter.
        /// AuthHelper.GetUserId(AuthState.Result.User)
        /// Or see simple GetUserId() method.
        /// </summary>
        /// <param name="claimsPrincipal"></param>
        /// <returns></returns>
        public static int GetUserId(ClaimsPrincipal claimsPrincipal)
        {
            if (!UserIsAuthenticated())
                return 0;

            if (claimsPrincipal != null && claimsPrincipal.Claims != null && claimsPrincipal.Claims.Any())
            {
                var userId = claimsPrincipal.Claims.Where(p => p.Type == "UserId").FirstOrDefault().Value;
                return int.Parse(userId);
            }

            // no claims or UserId claims - something gone wrong if we get here.
            System.Diagnostics.Debug.WriteLine("*** AuthHelper.GetUserId(ClaimsPrincipal claimsPrincipal) returning 0. Try use MBComponent.IsEnvironmentSet to check and redirect. ***");

            return 0;
        }

        public static int GetClientId(ClaimsPrincipal claimsPrincipal)
        {
            if (!UserIsAuthenticated())
                return -1;

            if (claimsPrincipal != null && claimsPrincipal.Claims != null && claimsPrincipal.Claims.Any())
            {
                var clientId = claimsPrincipal.Claims.Where(p => p.Type == "ClientId").FirstOrDefault().Value;
                return int.Parse(clientId);
            }

            // no claims or UserId claims - something gone wrong if we get here.
            System.Diagnostics.Debug.WriteLine("*** AuthHelper.GetClientId(ClaimsPrincipal claimsPrincipal) returning -1. Try use MBComponent.IsEnvironmentSet to check and redirect. ***");

            return -1;
        }


    }
}
