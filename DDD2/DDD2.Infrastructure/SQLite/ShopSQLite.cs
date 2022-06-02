using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Infrastructure.SQLite
{
    public class ShopSQLite : IShopRepository
    {
        public IReadOnlyList<ShopEntity> GetData()
        {
            string sql = @"
select 
ShopId,
ShopName,
Shop.LocationId,
LocationName
from Shop
left join Location
on Shop.LocationId = Location.LocationId;
";
            return SQLiteHelper.Query(sql,
                reader =>
                {
                    return new ShopEntity(
                        Convert.ToInt32(reader["ShopId"]),
                        Convert.ToString(reader["ShopName"]),
                        Convert.ToInt32(reader["LocationId"]),
                        Convert.ToString(reader["LocationName"])
                       );
                });
        }

        public ShopEntity GetDataSingle(int shopId)
        {
            throw new NotImplementedException();
        }
    }
}
