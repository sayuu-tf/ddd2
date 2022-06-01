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
select ShopName,
ShopId,
LocationName
from Shop
left join Location
on Shop.LocationId = Location.LocationId;
";
            return SQLiteHelper.Query(sql,
                reader =>
                {
                    return new ShopEntity(                        
                        Convert.ToString(reader["ShopName"]),
                        Convert.ToString(reader["LocationName"]),
                        Convert.ToInt32(reader["ShopId"])
                        );
                });
        }
    }
}
