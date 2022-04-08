using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Domain.Entities
{
    public sealed class ItemEntity
    {
        string ItemName { get; }
        int Price { get; }
        int ShopId { get; }

        public ItemEntity(string itemName, int price, int shopId)
        {
            ItemName = itemName;
            Price = price;
            ShopId = shopId;
        }
    }
}
