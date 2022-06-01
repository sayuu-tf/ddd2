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
        public ShopId ShopId { get; }
        public string ShopName { get; }
        public LocationId LocationId { get; }
        public string LocationName { get; }

        public ShopEntity(int shopId, string shopName, int locationId, string locationName)
        {
            ShopId = new ShopId(shopId);
            ShopName = shopName;
            LocationId = new LocationId(locationId);
            LocationName = locationName;
        }
    }
}
