using DDD2.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Domain.Entities
{
    public sealed class ShopEntity
    {
        public string ShopName { get; }
        public string LocationName { get; }
        public ShopId ShopId { get; }

        public ShopEntity(string shopName, string location, int shopId)
        {
            ShopName = shopName;
            LocationName = location;
            ShopId = new ShopId(shopId);
        }
    }
}
