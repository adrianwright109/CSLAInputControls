using System;
using System.Data;
using CSLAInputControls.Common.Enums;

namespace CSLAInputControls.Common
{
    public class OrmLiteParameter
    {
        public string Name { get; set; }
        public object Value { get; set; }
        public Type FieldType { get; set; }
        public DbType? DbType { get; set; }
        public ParameterDirection Direction { get; set; }
        public byte? Precision { get; set; }
        public byte? Scale { get; set; }
        public int? Size { get; set; }

        public static OrmLiteParameter CreateCharParameter(string name, string value, int length)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = System.Data.DbType.AnsiStringFixedLength,
                Direction = ParameterDirection.Input,
                Size = length
            };
        }

        /// <summary>
        /// Create a varchar parameter
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        /// <param name="length">Defaults to varchar(MAX) if none specified</param>
        /// <returns></returns>
        public static OrmLiteParameter CreateVarCharParameter(string name, string value, int length = -1)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = System.Data.DbType.AnsiString,
                Direction = ParameterDirection.Input,
                Size = length
            };
        }

        /// <summary>
        /// Create a nvarchar parameter
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="value">Value</param>
        /// <param name="length">Defaults to nvarchar(MAX) if none specified</param>
        /// <returns></returns>
        public static OrmLiteParameter CreateNVarCharParameter(string name, string value, int length = -1)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = System.Data.DbType.String,
                Direction = ParameterDirection.Input,
                Size = length
            };
        }

        public static OrmLiteParameter CreateClientEnvironmentParameter(string name, ClientEnvironment value)
        {
            return new()
            {
                Name = name,
                Value = value.ToString(),
                DbType = System.Data.DbType.AnsiStringFixedLength,
                Direction = ParameterDirection.Input,
                Size = 3
            };
        }

        public static OrmLiteParameter CreateDecimalIntegerParameter(string name, int value, DbType dbType = System.Data.DbType.Decimal, int maxLength = 9, int numberOfDecimalPlaces = 0)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = dbType,
                Direction = ParameterDirection.Input,
                Precision = (byte)maxLength,
                Scale = (byte)numberOfDecimalPlaces
            };
        }

        public static OrmLiteParameter CreateIntegerParameter(string name, int value, DbType dbType = System.Data.DbType.Int32)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = dbType,
                Direction = ParameterDirection.Input
            };
        }

        public static OrmLiteParameter CreateMandatoryNullableIntegerParameter(string name, int? value, DbType dbType = System.Data.DbType.Int32)
        {
            return new()
            {
                Name = name,
                Value = (object)value ?? DBNull.Value,
                DbType = dbType,
                Direction = ParameterDirection.Input
            };
        }

        public static OrmLiteParameter CreateOptionalNullableIntegerParameter(string name, int? value, DbType dbType = System.Data.DbType.Int32)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = dbType,
                Direction = ParameterDirection.Input
            };
        }

        public static OrmLiteParameter CreateParameter(string name, bool value, DbType dbType)
        {
            return new()
            {
                Name = name,
                Value = value,
                DbType = dbType,
                Direction = ParameterDirection.Input
            };
        }

        public static OrmLiteParameter CreateParameter(string name, DbType dbType, ParameterDirection direction)
        {
            return new()
            {
                Name = name,
                DbType = dbType,
                Direction = direction
            };
        }
    }
}
