﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DDD2.Infrastructure.SQLServer
{
    internal static class SqlServerHelper
    {
        internal readonly static string ConnectionString;

        static SqlServerHelper()
        {
            var builder = new SqlConnectionStringBuilder();
            builder.DataSource = @"DESKTOP-N3KO8J5";
            builder.InitialCatalog = "study_ddd2";
            builder.IntegratedSecurity = true;
            ConnectionString = builder.ConnectionString;
        }

        internal static void Query(
            string sql,
            SqlParameter[] parameters,
            Action<SqlDataReader> action)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {
                connection.Open();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        action(reader);
                    }
                }
            }
        }

        internal static void Execute(
            string sql,
            SqlParameter[] parameters)
        {
            using (var connection = new SqlConnection(ConnectionString))
            using (var command = new SqlCommand(sql, connection))
            {

                connection.Open();

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                command.ExecuteNonQuery();
            }
        }
    }
}