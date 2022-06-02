﻿using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
select 
ShopId,
ShopName,
Shop.LocationId,
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
                            Convert.ToInt32(reader["ShopId"]),
                            Convert.ToString(reader["ShopName"]),
                            Convert.ToInt32(reader["LocationId"]),
                            Convert.ToString(reader["LocationName"])
                        );

                    result.Add(shop);
                });
            
            return result;
        }

        public ShopEntity GetDataSingle(int shopId)
        {
            string sql = @"
select 
ShopId,
ShopName,
Shop.LocationId,
LocationName
from Shop
left join Location
on Shop.LocationId = Location.LocationId
where ShopId = @ShopId
;
";
            ShopEntity shop = null;
            SqlServerHelper.Query(sql,
                new List<SqlParameter> { new SqlParameter("@ShopId", shopId) }.ToArray(),
                reader =>
                {
                    shop = new ShopEntity(
                            Convert.ToInt32(reader["ShopId"]),
                            Convert.ToString(reader["ShopName"]),
                            Convert.ToInt32(reader["LocationId"]),
                            Convert.ToString(reader["LocationName"])
                        );

                });

            return shop;
        }
    }
}