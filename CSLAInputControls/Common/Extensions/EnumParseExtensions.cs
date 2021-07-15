using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using CSLAInputControls.Common.Attributes;
using CSLAInputControls.Common.DTOs;

namespace MB5.Common.Extensions
{
    public static class EnumParseExtensions
    {
        public static IEnumerable<TEnum> EnumGetOrderedValues<TEnum>(this Type enumType) where TEnum : Enum
        {
            var fields = enumType.GetFields(BindingFlags.Public | BindingFlags.Static);
            var orderedValues = new List<Tuple<int, TEnum>>();

            foreach (var field in fields)
            {
                if (field.GetCustomAttributes(typeof(EnumOrderAttribute), false).SingleOrDefault() is EnumOrderAttribute orderAtt)
                {
                    orderedValues.Add(new Tuple<int, TEnum>(orderAtt.Order, (TEnum)field.GetValue(null)));
                }
            }

            return orderedValues.OrderBy(x => x.Item1).Select(x => x.Item2).ToList();
        }

        public static IEnumerable<DropDownDto> EnumGetOrderedValuesForDropDown<TEnum>(this Type enumType) where TEnum : Enum
        {
            var orderedEnumValues = EnumGetOrderedValues<TEnum>(enumType);

            return orderedEnumValues.Select(x => new DropDownDto { Key = ToIntValueFromEnum(x), Value = x.ToDisplayName() });
        }

        public static TEnum ToEnumFromCharStringValue<TEnum>(string valueAsString) where TEnum : Enum
        {
            return ConvertToEnumFromIntValue<TEnum>(valueAsString.ToCharArray()[0]);
        }

        public static TEnum ToEnumFromCharValue<TEnum>(char valueAsChar) where TEnum : Enum
        {
            return ConvertToEnumFromIntValue<TEnum>(valueAsChar);
        }

        public static char ToCharValueFromEnum<TEnum>(TEnum @enum) where TEnum : Enum
        {
            return Convert.ToChar(@enum);
        }

        public static char ToCharValueFromStringText<TEnum>(string textAsString) where TEnum : Enum
        {
            var @enum = ConvertToEnumFromTextString<TEnum>(textAsString);
            return ToCharValueFromEnum(@enum);
        }

        public static TEnum ToEnumFromIntStringValue<TEnum>(string valueAsString) where TEnum : Enum
        {
            return ToEnumFromIntValue<TEnum>(Convert.ToInt32(valueAsString));
        }

        public static TEnum ToEnumFromIntValue<TEnum>(int valueAsInt) where TEnum : Enum
        {
            return ConvertToEnumFromIntValue<TEnum>(valueAsInt);
        }

        public static int ToIntValueFromEnum<TEnum>(TEnum @enum) where TEnum : Enum
        {
            return Convert.ToInt32(@enum);
        }

        public static int ToIntValueFromStringText<TEnum>(string textAsString) where TEnum : Enum
        {
            var @enum = ConvertToEnumFromTextString<TEnum>(textAsString);
            return ToIntValueFromEnum(@enum);
        }

        public static TEnum ToEnumFromStringText<TEnum>(string textAsString) where TEnum : Enum
        {
            return ConvertToEnumFromTextString<TEnum>(textAsString);
        }

        public static TEnum ToEnumFromStringDescription<TEnum>(string enumDescription) where TEnum : Enum
        {
            //get a list of all the enum options
            var enumOptions = typeof(TEnum).EnumGetOrderedValues<TEnum>().ToList();

            foreach (var @enum in enumOptions)
            {
                var description = @enum.ToDisplayName();

                if (description == enumDescription)
                {
                    return @enum;
                }
            }

            throw new ArgumentException($"'{enumDescription}' is not a valid {typeof(TEnum).Name}.");
        }

        private static TEnum ConvertToEnumFromIntValue<TEnum>(int enumValue) where TEnum : Enum
        {
            var enumType = typeof(TEnum);

            if (Enum.IsDefined(enumType, enumValue))
            {
                return (TEnum)Enum.ToObject(enumType, enumValue);
            }

            throw new InvalidEnumArgumentException("Enum value not defined.", enumValue, enumType);
        }

        private static TEnum ConvertToEnumFromTextString<TEnum>(string textAsString) where TEnum : Enum
        {
            var enumType = typeof(TEnum);

            if (Enum.IsDefined(enumType, textAsString))
            {
                return (TEnum)Enum.Parse(enumType, textAsString);
            }

            throw new InvalidEnumArgumentException("Enum value not defined.", 0, enumType);
        }
    }
}
