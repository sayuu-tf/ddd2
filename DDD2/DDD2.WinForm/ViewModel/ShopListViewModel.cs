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
        public BindingList<ShopListViewModelShop> Shops { get; set; }
        = new BindingList<ShopListViewModelShop>();
    }
}
