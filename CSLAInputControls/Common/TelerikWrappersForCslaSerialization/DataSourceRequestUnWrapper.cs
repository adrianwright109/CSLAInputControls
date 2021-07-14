using System;
using Telerik.DataSource;

namespace CSLAInputControls.Common.TelerikWrappersForCslaSerialization
{
    [Serializable]
    public class DataSourceRequestUnWrapper
    {
        /// <summary>
        /// Blazor Telerik Grid State object
        /// </summary>
        public DataSourceRequest GridRequest { get; set; }

        /// <summary>
        /// Which row to start at when returning data from the database
        /// as the data is paged.
        /// </summary>
        public int RowOffset
        {
            get
            {
                if (GridRequest != null)
                {
                    return GridRequest.PageSize * (GridRequest.Page - 1);
                }

                return 0;
            }
        }
    }
}
