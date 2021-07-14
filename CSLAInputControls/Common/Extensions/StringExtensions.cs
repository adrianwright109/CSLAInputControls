using System.Text.RegularExpressions;

namespace CSLAInputControls.Common.Extensions
{
    public static class StringExtensions
    {
        public static string ToSqlSafeLikeData(this string val)
        {
            return Regex.Replace(val, @"([%_\[])", @"[$1]").Replace("'", "''");
        }

        public static string ToSqlSafeString(this string val)
        {
            return "'" + val.Replace("'", "''") + "'";
        }
    }
}
