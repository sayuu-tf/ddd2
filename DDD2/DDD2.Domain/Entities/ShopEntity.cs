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
        public string Location { get; }
        public int ShopId { get; }

        public ShopEntity(string shopName, string location, int shopId)
        {
            ShopName = shopName;
            Location = location;
            ShopId = shopId;
        }
    }
}
