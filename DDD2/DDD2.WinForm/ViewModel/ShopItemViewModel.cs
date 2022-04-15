using DDD2.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm.ViewModel
{
    public class ShopItemViewModel: ViewModelBase
    {
        private IItemRepository _items;

        public ShopItemViewModel(IItemRepository items)
        {
            _items = items;
        }

        public string _selectedShopId = String.Empty;
        public string SelectedShopId
        {
            get { return _selectedShopId; }
            set { SetProperty(ref _selectedShopId, value); }
        }

        public string _shopNameText = String.Empty;
        public string ShopNameText
        {
            get { return _shopNameText; }
            set { SetProperty(ref _shopNameText, value); }
        }

        public string _itemNameText;
        public string ItemNameText
        {
            get
            {
                return _itemNameText;
            }
            set
            {
                SetProperty(ref _itemNameText, value);
            }
        }


        public string _itemPriceText = String.Empty;
        public string ItemPriceText
        {
            get
            {
                return _itemPriceText;
            }
            set
            {
                SetProperty(ref _itemPriceText, value);
            }
        }


        public void Search()
        {
            var entity = _items.GetHighestPriceItem(Convert.ToInt32(SelectedShopId));
            if (entity == null)
            {
                ShopNameText = String.Empty;
                ItemNameText = String.Empty;
                ItemPriceText = String.Empty;
            }
            else
            {
                //ShopNameText = entity.ItemName
                ItemNameText = entity.ItemName;
                ItemPriceText = entity.Price.ToString();
            }
        }
    }
}
