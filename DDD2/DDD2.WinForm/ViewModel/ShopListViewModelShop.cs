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

        public string ShopId => _entity.ShopId.DisplayValue;
        public string ShopName => _entity.ShopName;
        public string LocationName => _entity.LocationName;

        //ここのメンバの名前が、表示される列名になる。
        //LocationNameなら、画面上にもLocationNameと表示される。
    }
}
