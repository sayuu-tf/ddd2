using DDD2.WinForm.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD2.WinForm
{
    public partial class ShopItemListView : Form
    {
        private ShopSelectViewModel _viewModel = new ShopSelectViewModel();

        public ShopItemListView()
        {
            InitializeComponent();

            //データバインディング

            this.ShopSelectTextBox.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.SelectedShopId));
            this.ShopNameText.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.ShopNameText));
            this.LocationText.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.LocationNameText));
            this.ProfitText.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.ProfitText));
            this.LocationComboBox.DataBindings.Add(
                "SelectedValue", _viewModel, nameof(_viewModel.SelectedLocationId));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var f = new ShopListView())
            {
                f.ShowDialog();
            }
        }

        private void ShopSelectButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search();
        }

        private void LocationButton_Click(object sender, EventArgs e)
        {
            _viewModel.Search2();
        }
    }
}
