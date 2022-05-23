using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm.ViewModel
{
    public class ShopListViewModel : ViewModelBase
    {
        private IShopRepository _shop;
        public ShopListViewModel(IShopRepository shop)
        {
            _shop = shop;
        }
        public BindingList<ShopListViewModelShop> Shops { get; set; }
        = new BindingList<ShopListViewModelShop>();
    }
}
