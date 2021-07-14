using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Telerik.DataSource;

namespace CSLAInputControls.Common.Extensions
{
    public static class IFilterDescriptorExtensions
    {
        public static string BuildWhereClauseAndAddCommandParameters(this IList<IFilterDescriptor> filters,
            List<OrmLiteParameter> parameters,
            FilterCompositionLogicalOperator compositionOperator = FilterCompositionLogicalOperator.And)
        {
            if (filters == null || !filters.Any())
            {
                return string.Empty;
            }

            var result = "(";
            var combineWith = string.Empty;

            foreach (var filter in filters)
            {
                if (filter is FilterDescriptor fd)
                {
                    result += $"{combineWith}({fd.ToSqlServerWhereClausePredicate(parameters)})";
                }
                else if (filter is CompositeFilterDescriptor cfd)
                {
                    result += $"{combineWith}({cfd.FilterDescriptors.BuildWhereClauseAndAddCommandParameters(parameters, cfd.LogicalOperator)})";
                }

                combineWith = compositionOperator == FilterCompositionLogicalOperator.And ? " AND " : " OR ";
            }

            result += ")";

            return result;
        }

        public static void UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(this IList<IFilterDescriptor> filters,
            IMapper mapper)
        {
            if (filters == null || !filters.Any())
            {
                return;
            }

            foreach (var filter in filters)
            {
                if (filter is FilterDescriptor fd)
                {
                    fd.UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(mapper);
                }
                else if (filter is CompositeFilterDescriptor cfd)
                {
                    cfd.FilterDescriptors.UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(mapper);
                }
            }
        }
    }
}
