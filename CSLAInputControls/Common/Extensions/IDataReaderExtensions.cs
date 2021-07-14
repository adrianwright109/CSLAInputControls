using System.Data;
using CSLAInputControls.Common.Helpers;

namespace CSLAInputControls.Common.Extensions
{
    public static class IDataReaderExtensions
    {
        public static bool ConvertYNToBoolean(this IDataReader dataReader, int fieldIndex)
        {
            return ConversionHelper.ConvertYNToBoolean(dataReader.GetString(fieldIndex).Trim().ToUpper());
        }

        public static bool? ConvertYNToNullableBoolean(this IDataReader dataReader, int fieldIndex)
        {
            return ConversionHelper.ConvertYNToNullableBoolean(dataReader.GetString(fieldIndex).Trim().ToUpper());
        }

        public static bool GetSMRCStatus(this IDataReader dataReader, int fieldIndex)
        {
            return ConversionHelper.GetSMRCStatus(dataReader.GetString(fieldIndex).Trim().ToUpper());
        }
    }
}
