using DDD2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm.ViewModel
{
    public sealed class ShopListViewModelShop
    {
        private ShopEntity _entity;
        public ShopListViewModelShop(ShopEntity entity)
        {
            _entity = entity;
        }
    }
}
