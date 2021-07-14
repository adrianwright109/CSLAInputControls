using System;
using System.Data;
using CSLAInputControls.Common.Enums;

namespace CSLAInputControls.Common.Extensions
{
    public static class IDbCommandExtensions
    {
        public static void AddCharParameter(this IDbCommand command, string name, string value, int length)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = DbType.AnsiStringFixedLength;
            parameter.Size = length;

            command.Parameters.Add(parameter);
        }

        public static void AddVarCharParameter(this IDbCommand command, string name, string value, int length)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = DbType.AnsiString;
            parameter.Size = length;

            command.Parameters.Add(parameter);
        }

        public static void AddNVarCharParameter(this IDbCommand command, string name, string value, int length)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = DbType.String;
            parameter.Size = length;

            command.Parameters.Add(parameter);
        }

        public static void AddClientEnvironmentParameter(this IDbCommand command, string name, ClientEnvironment value)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value.ToString();
            parameter.DbType = DbType.AnsiStringFixedLength;
            parameter.Size = 3;

            command.Parameters.Add(parameter);
        }

        public static void AddDecimalIntegerParameter(this IDbCommand command, string name, int value, DbType dbType = DbType.Decimal, int maxLength = 9, int numberOfDecimalPlaces = 0)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = dbType;
            parameter.Precision = (byte)maxLength;
            parameter.Scale = (byte)numberOfDecimalPlaces;

            command.Parameters.Add(parameter);
        }

        public static void AddIntegerParameter(this IDbCommand command, string name, int value, DbType dbType = DbType.Int32)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = dbType;

            command.Parameters.Add(parameter);
        }

        public static void AddMandatoryNullableIntegerParameter(this IDbCommand command, string name, int? value, DbType dbType = DbType.Int32)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = (object)value ?? DBNull.Value;
            parameter.DbType = dbType;

            command.Parameters.Add(parameter);
        }

        public static void AddOptionalNullableIntegerParameter(this IDbCommand command, string name, int? value, DbType dbType = DbType.Int32)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = dbType;

            command.Parameters.Add(parameter);
        }

        public static void AddParameter(this IDbCommand command, string name, bool value, DbType dbType)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.Value = value;
            parameter.DbType = dbType;

            command.Parameters.Add(parameter);
        }

        public static IDbDataParameter CreateParameter(this IDbCommand command, string name, DbType dbType, ParameterDirection direction)
        {
            var parameter = command.CreateParameter();
            parameter.ParameterName = name;
            parameter.DbType = dbType;
            parameter.Direction = direction;

            return parameter;
        }

        public static void Add_ClientId_ClientEnvironment_SessionId_Parameters(this IDbCommand command, 
            int clientId, 
            ClientEnvironment clientEnvironment, 
            int sessionId)
        {
            command.AddDecimalIntegerParameter("@ClientId", clientId);
            command.AddClientEnvironmentParameter("@EnvironmentCode", clientEnvironment);
            command.AddDecimalIntegerParameter("@SessionId", sessionId);
        }
    }
}
