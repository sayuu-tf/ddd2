using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Infrastructure.SQLServer
{
    public class ShopSQLServer : IShopRepository
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
            ShopEntity shop = null;
            var result = new List<ShopEntity>();
            SqlServerHelper.Query(sql,null,
                reader =>
                {
                    shop = new ShopEntity(
                        Convert.ToString(reader["ShopName"]),
                        Convert.ToString(reader["LocationName"]),
                        Convert.ToInt32(reader["ShopId"])
                        );

                    result.Add(shop);
                });
            
            return result;
        }
    }
}
