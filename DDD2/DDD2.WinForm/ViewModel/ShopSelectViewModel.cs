using DDD2.Domain.Repositories;
using DDD2.WinForm.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm
{
    public class ShopSelectViewModel : ViewModelBase
    {
        private IShopRepository _shop;

        public ShopSelectViewModel(IShopRepository shop)
        {
            _shop = shop;
        }

        public object _selectedShopId;
        public object SelectedShopId
        {
            get { return _selectedShopId; }
            set
            {
                SetProperty(ref _selectedShopId, value);
            }
        }

        public string _shopNameText = String.Empty;
        public string ShopNameText
        {
            get { return _shopNameText; }
            set
            {
                SetProperty(ref _shopNameText, value);
            }
        }

        public string _locationNameText = String.Empty;
        public string LocationNameText
        {
            get { return _locationNameText; }
            set
            {
                SetProperty(ref _locationNameText, value);
            }
        }

        public void Search()
        {
            var entity = _shop.Select((Convert.ToInt32(_selectedShopId)));

            if (entity == null)
            {
                ShopNameText = String.Empty;
                LocationNameText = String.Empty;
            }
            else
            {
                ShopNameText = entity.ShopName;
                LocationNameText = entity.LocationName;
            }
        }
    }
}
