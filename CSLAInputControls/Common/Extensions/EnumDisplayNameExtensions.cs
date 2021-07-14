using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using ServiceStack;

namespace CSLAInputControls.Common.Extensions
{
    public static class EnumDisplayNameExtensions
    {
        public static string ToDisplayName(this Enum @enum)
        {
            var type = @enum.GetType();

            var memInfo = type.GetMember(@enum.ToString());

            if (memInfo.Length > 0)
            {
                var displayName = memInfo[0].GetDisplayName();

                if (displayName != null)
                {
                    return displayName;
                }
            }

            return @enum.ToString();
        }

        private static string GetDisplayName(this MemberInfo mi)
        {
            var displayNameAttribute = mi.FirstAttribute<DisplayNameAttribute>();
            if (displayNameAttribute != null)
            {
                return displayNameAttribute.DisplayName;
            }

            var displayAttribute = mi.FirstAttribute<DisplayAttribute>();

            return displayAttribute?.Name;
        }
    }
}
