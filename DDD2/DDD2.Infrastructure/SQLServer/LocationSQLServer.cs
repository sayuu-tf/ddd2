using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
