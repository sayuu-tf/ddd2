using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DDD2.Infrastructure.SQLServer
{
    public class LocationSQLServer : ILocationRepository
    {
        public IReadOnlyList<LocationEntity> GetData()
        {
            string sql = @"
select
LocationId,
LocationName
from Location;;
";
            LocationEntity loc = null;
            var result = new List<LocationEntity>();
            SqlServerHelper.Query(sql, null,
                reader =>
                {
                    loc = new LocationEntity(
                            Convert.ToInt32(reader["LocationId"]),
                            Convert.ToString(reader["LocationName"])
                        );

                    result.Add(loc);
                });

            return result;
        }

        public void Save(LocationEntity location)
        {
            string insert = @"
insert into Location
(LocationId, LocationName)
values
(@LocationId, @LocationName);
";

            var args = new List<SqlParameter>
            {
                new SqlParameter("@LocationId", location.LocationId.Value),
                new SqlParameter("@LocationName", location.LocationName)
            };

            SqlServerHelper.Execute(insert, args.ToArray());
        }
    }
}
