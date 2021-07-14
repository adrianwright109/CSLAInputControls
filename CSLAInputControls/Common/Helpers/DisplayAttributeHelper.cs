using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace CSLAInputControls.Common.Helpers
{
    public static class DisplayAttributeHelper
    {
        public static string GetDisplay<T>(string propertyName)
        {
            var property = typeof(T).GetProperty(propertyName);

            if (property != null && property.GetCustomAttribute(typeof(DisplayAttribute)) is DisplayAttribute displayAttribute)
            {
                return displayAttribute.Name;
            }

            return propertyName;
        }
    }
}
