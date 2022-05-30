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
select ShopId,
ShopId,
Location
from Shop
";
            return SQLiteHelper.Query(sql,
                reader =>
                {
                    return new ShopEntity(                        
                        Convert.ToString(reader["ShopName"]),
                        Convert.ToString(reader["Location"]),
                        Convert.ToInt32(reader["ShopId"])
                        );
                });
        }
    }
}
