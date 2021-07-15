using System;
using MB5.Common.Extensions;

namespace MB5.Client.Shared
{
    public class CslaDisplayOnlyBase : CslaHtmlElementBase
    {
        protected object Value
        {
            get
            {
                var value = Property.Value;

                if (Property.CanRead)
                {
                    string defaultFormat = null;

                    switch (value)
                    {
                        case double:
                            defaultFormat = "{0:N2}";
                            break;
                        case decimal:
                            defaultFormat = "{0:F2}";
                            break;
                        case int:
                            defaultFormat = "{0:N0}";
                            break;
                        case DateTime:
                            defaultFormat = "{0:dd MMM yyyy}";
                            break;
                        case bool yes:
                            value = yes? "Yes" : "No";
                            break;
                        default:
                            break;
                    }

                    if (string.IsNullOrWhiteSpace(Format))
                    {
                        Format = defaultFormat;
                    }

                    if (!string.IsNullOrWhiteSpace(Format))
                    {
                        value = string.Format(Format, Property.Value);
                    }

                    if (value is Enum anEnum)
                    {
                        value = anEnum.ToDisplayName();
                    }
                }
                else
                {
                    value = "*****";
                }

                return value;
            }
        }
    }
}
