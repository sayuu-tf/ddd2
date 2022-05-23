using DDD2.WinForm.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DDD2.WinForm.View
{
    public partial class ShopListView : Form
    {
        private ShopListViewModel _viewModel = new ShopListViewModel();

        public ShopListView()
        {
            InitializeComponent();

            ShopDataGrid.DataBindings.Add(
                "DataSource", _viewModel, nameof(_viewModel.Shops));
        }
    }
}
