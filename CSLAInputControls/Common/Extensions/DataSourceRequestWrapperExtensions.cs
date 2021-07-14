using System;
using System.Text.Json;
using CSLAInputControls.Common.TelerikWrappersForCslaSerialization;
using Telerik.DataSource;

namespace CSLAInputControls.Common.Extensions
{
    public static class DataSourceRequestWrapperExtensions
    {
        /// <summary>
        /// De-Serialize <see cref="DataSourceRequestWrapper"/> object as <see cref="DataSourceRequest"/>
        /// using <see cref="JsonSerializer"/> so that it can be used in CSLA DataPortal.
        /// </summary>
        /// <param name="dataSourceRequestWrapper">Object to de-serialise and un-wrap</param>
        /// <returns><see cref="DataSourceRequestUnWrapper"/></returns>
        public static DataSourceRequestUnWrapper UnWrap(this DataSourceRequestWrapper dataSourceRequestWrapper)
        {
            var readOnlySpan = new ReadOnlySpan<byte>(dataSourceRequestWrapper.DataSourceRequestAsJson);
            var gridRequest = JsonSerializer.Deserialize<DataSourceRequest>(readOnlySpan);

            return new DataSourceRequestUnWrapper { GridRequest = gridRequest };
        }
    }
}
