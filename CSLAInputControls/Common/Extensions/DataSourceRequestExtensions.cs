using System;
using System.Collections.Generic;
using System.Text.Json;
using AutoMapper;
using CSLAInputControls.Common.Helpers;
using CSLAInputControls.Common.TelerikWrappersForCslaSerialization;
using Telerik.DataSource;

namespace CSLAInputControls.Common.Extensions
{
    public static class DataSourceRequestExtensions
    {
        /// <summary>
        /// Serialize <see cref="DataSourceRequest"/> object as a UTF-8 JSON byte array
        /// using <see cref="JsonSerializer"/> so that it can be transferred to CSLA DataPortal.
        /// </summary>
        /// <param name="dataSourceRequest">Object to serialise and wrap</param>
        /// <param name="mapper">Auto Mapper</param>
        /// <returns><see cref="DataSourceRequestWrapper"/></returns>
        public static DataSourceRequestWrapper Wrap<TSource, TDestination>(this DataSourceRequest dataSourceRequest, IMapper mapper)
        {
            //take a copy of the dataSourceRequest as we will updating the property names to match the database column names
            //and we don't want to modify the actual request itself.  Easiest way to make a copy is to serialize it as JSON and then de-serialize it back into a new object.
            var dataSourceRequestCopy = JsonSerializer.Deserialize<DataSourceRequest>(new ReadOnlySpan<byte>(JsonSerializer.SerializeToUtf8Bytes(dataSourceRequest)));

            if (dataSourceRequestCopy != null)
            {
                dataSourceRequestCopy.Filters.UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(mapper);
                dataSourceRequestCopy.UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(mapper);
            }

            var jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(dataSourceRequestCopy);

            return new DataSourceRequestWrapper {DataSourceRequestAsJson = jsonUtf8Bytes};
        }

        public static string BuildOrderByClause(this DataSourceRequest dataSourceRequest)
        {
            var orderedMembers = new List<string>();
            var orderByClause = string.Empty;
            var comma = string.Empty;

            if (dataSourceRequest.Groups != null)
            {
                foreach (var group in dataSourceRequest.Groups)
                {
                    orderByClause = AddOrderByClauseForColumn(orderedMembers, group, ref orderByClause, ref comma);
                }
            }

            if (dataSourceRequest.Sorts != null)
            {
                foreach (var sort in dataSourceRequest.Sorts)
                {
                    orderByClause = AddOrderByClauseForColumn(orderedMembers, sort, ref orderByClause, ref comma);
                }
            }

            return orderByClause;
        }

        public static void UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(this DataSourceRequest dataSourceRequest, IMapper mapper)
        {
            if (dataSourceRequest.Groups != null)
            {
                foreach (var group in dataSourceRequest.Groups)
                {
                    UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(mapper, group);
                }
            }

            if (dataSourceRequest.Sorts != null)
            {
                foreach (var sort in dataSourceRequest.Sorts)
                {
                    UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(mapper, sort);
                }
            }
        }

        private static string AddOrderByClauseForColumn(List<string> orderedMembers, SortDescriptor sort, ref string orderByClause, ref string comma)
        {
            if (orderedMembers.Contains(sort.Member))
            {
                return orderByClause;
            }

            orderByClause += $"{comma} {sort.Member}{(sort.SortDirection == ListSortDirection.Ascending ? " ASC" : " DESC")}";

            comma = ",";
            orderedMembers.Add(sort.Member);

            return orderByClause;
        }

        private static void UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(IMapper mapper, SortDescriptor sort)
        {
            sort.Member = AutoMapperHelper.GetSourcePropertyNameFor<TSource, TDestination>(mapper, sort.Member);
        }
    }
}
