namespace CSLAInputControls.Common.Helpers
{
    public static class ConversionHelper
    {
        public static bool ConvertYNToBoolean(string value)
        {
            return value == "Y";
        }

        public static bool? ConvertYNToNullableBoolean(string value)
        {
            switch (value)
            {
                case "Y":
                    return true;
                case "N":
                    return false;
                default:
                    return null;
            }
        }

        public static bool GetSMRCStatus(string status)
        {
            return status == "A";
        }

        public static bool FixedCostServiceStatus(string status)
        {
            return status == "A";
        }

        public static bool FixedCostServiceItemIncluded(string status)
        {
            return status == "A";
        }
    }
}
