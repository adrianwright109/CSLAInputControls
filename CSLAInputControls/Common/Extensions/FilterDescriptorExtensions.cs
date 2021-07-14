using System;
using System.Collections.Generic;
using System.Data;
using AutoMapper;
using CSLAInputControls.Common.Helpers;
using Telerik.DataSource;

namespace CSLAInputControls.Common.Extensions
{
    public static class FilterDescriptorExtensions
    {
        public static string ToSqlServerWhereClausePredicate(this FilterDescriptor fd,
            List<OrmLiteParameter> parameters)
        {
            var parameterName = $"@p{parameters.Count}";
            string result;

            // Some string filter values are modified for use as parameters in a SQL LIKE clause, thus work with a copy.
            // The original value must remain unchanged for when ToDataSourceResultAsync(gridRequest) is used later.

            var filterValue = fd.Value;

            switch (fd.Operator)
            {
                case FilterOperator.IsLessThan: 
                    result = $"[{fd.Member}] < {parameterName}";
                    break;
                case FilterOperator.IsLessThanOrEqualTo: 
                    result = $"[{fd.Member}] <= {parameterName}"; 
                    break;
                case FilterOperator.IsEqualTo: 
                    result = $"[{fd.Member}] = {parameterName}"; 
                    break;
                case FilterOperator.IsNotEqualTo: 
                    result = $"[{fd.Member}] <> {parameterName}"; 
                    break;
                case FilterOperator.IsGreaterThanOrEqualTo: 
                    result = $"[{fd.Member}] >= {parameterName}"; 
                    break;
                case FilterOperator.IsGreaterThan: 
                    result = $"[{fd.Member}] > {parameterName}"; 
                    break;
                case FilterOperator.StartsWith:
                    filterValue = $"{fd.Value.ToString().ToSqlSafeLikeData()}%";
                    result = $"[{fd.Member}] LIKE {parameterName}"; 
                    break;
                case FilterOperator.EndsWith:
                    filterValue = $"%{fd.Value.ToString().ToSqlSafeLikeData()}";
                    result = $"[{fd.Member}] LIKE {parameterName}"; 
                    break;
                case FilterOperator.Contains:
                    filterValue = $"%{fd.Value.ToString().ToSqlSafeLikeData()}%";
                    result = $"[{fd.Member}] LIKE {parameterName}"; 
                    break;
                case FilterOperator.IsContainedIn:
                    result = $"CHARINDEX([{fd.Member}], '{fd.Value.ToString().ToSqlSafeLikeData()}') > 0";
                    break;
                case FilterOperator.DoesNotContain:
                    filterValue = $"%{fd.Value.ToString().ToSqlSafeLikeData()}";
                    result = $"[{fd.Member}] NOT LIKE {parameterName}"; 
                    break;
                case FilterOperator.IsNull: 
                    result = $"[{fd.Member}] IS NULL"; 
                    break;
                case FilterOperator.IsNotNull: 
                    result = $"[{fd.Member}] IS NOT NULL"; 
                    break;
                case FilterOperator.IsEmpty: 
                    result = $"[{fd.Member}] = ''"; 
                    break;
                case FilterOperator.IsNotEmpty: 
                    result = $"[{fd.Member}] <> ''"; 
                    break;
                case FilterOperator.IsNullOrEmpty:
                    result = $"([{fd.Member}] IS NULL OR [{fd.Member}] = '')";
                    break;
                case FilterOperator.IsNotNullOrEmpty:
                    result = $"(COALESCE([{fd.Member}], '') <> '')";
                    break;
                default:
                    throw new Exception($"There is no translator for [{fd.Member}] {fd.Operator} {fd.Value}");
            }

            parameters.Add(new OrmLiteParameter
            {
                Name = parameterName,
                Value = filterValue,
                Direction = ParameterDirection.Input
            });

            return result;
        }

        public static void UpdatePropertyNamesToMatchDatabasePOCOs<TSource, TDestination>(this FilterDescriptor fd, IMapper mapper)
        {
            fd.Member = AutoMapperHelper.GetSourcePropertyNameFor<TSource, TDestination>(mapper, fd.Member);
        }
    }
}
