using System.Collections.Generic;
using System.Data;
using ServiceStack.OrmLite;

namespace CSLAInputControls.Common.Extensions
{
    public static class OrmLiteParameterExtensions
    {
        public static IEnumerable<IDbDataParameter> ToIDbDataParameters(this IEnumerable<OrmLiteParameter> ormLiteDataParameters,
            IDbConnection db)
        {
            List<IDbDataParameter> parameters = new();

            foreach (var ormLiteDataParameter in ormLiteDataParameters)
            {
                //remove any @ symbols from the name as db.CreateParam adds one to the start regardless
                var paramName = ormLiteDataParameter.Name.StartsWith("@") ? ormLiteDataParameter.Name.Substring(1) : ormLiteDataParameter.Name;

                var dbDataParameter = db.CreateParam(paramName,
                    ormLiteDataParameter.Value,
                    ormLiteDataParameter.FieldType,
                    ormLiteDataParameter.DbType,
                    ormLiteDataParameter.Precision,
                    ormLiteDataParameter.Scale,
                    ormLiteDataParameter.Size);

                dbDataParameter.Direction = ormLiteDataParameter.Direction;

                parameters.Add(dbDataParameter);
            }

            return parameters;
        }
    }
}
