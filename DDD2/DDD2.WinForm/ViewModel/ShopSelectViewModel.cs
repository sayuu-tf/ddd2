using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using DDD2.Domain.ValueObjects;
using DDD2.Infrastructure.SQLServer;
using DDD2.WinForm.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm
{
    public class ShopSelectViewModel : ViewModelBase
    {
        private IShopRepository _shops;
        private ILocationRepository _locations;

        public ShopSelectViewModel()
            :this(new ShopSQLServer(), new LocationSQLServer())
        {

        }

        public ShopSelectViewModel(
            IShopRepository shops,
            ILocationRepository locations)
        {
            _shops = shops;
            _locations = locations;

            foreach (var shop in _shops.GetData())
            {
                
                Shops.Add(new ShopEntity(shop.ShopId.Value, shop.ShopName, shop.LocationId.Value, shop.LocationName, shop.Profit));
            }

            foreach (var loc in _locations.GetData())
            {

                Locations.Add(new LocationEntity(loc.LocationId.Value, loc.LocationName));
            }
        }

        public LocationId _selectedLocationId;
        public LocationId SelectedLocationId
        {
            get { return _selectedLocationId; }
            set
            {
                SetProperty(ref _selectedLocationId, value);
            }
        }

        public string _selectedShopId = String.Empty;
        public string SelectedShopId
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

        public string _profitText = String.Empty;
        public string ProfitText
        {
            get { return _profitText; }
            set
            {
                SetProperty(ref _profitText, value);
            }
        }

        public BindingList<ShopEntity> Shops { get; set; } = new BindingList<ShopEntity>();
        public BindingList<LocationEntity> Locations { get; set; }
        = new BindingList<LocationEntity>();

        public void Search()
        {
            var entity = _shops.GetDataSingle((Convert.ToInt32(_selectedShopId)));

            if (entity == null)
            {
                ShopNameText = String.Empty;
                LocationNameText = String.Empty;
                ProfitText = String.Empty;
            }
            else
            {
                ShopNameText = entity.ShopName;
                LocationNameText = entity.LocationName;
                ProfitText = entity.Profit.ToString();
            }
        }

        public void Search2()
        {
            var entity = _shops.GetMaxProfitData((Convert.ToInt32(_selectedLocationId.Value)));

            if (entity == null)
            {
                ShopNameText = String.Empty;
                LocationNameText = String.Empty;
                ProfitText = String.Empty;
            }
            else
            {
                ShopNameText = entity.ShopName;
                LocationNameText = entity.LocationName;
                ProfitText = entity.Profit.ToString();
            }
        }
    }
}
