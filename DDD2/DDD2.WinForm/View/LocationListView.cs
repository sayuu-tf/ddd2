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
    public partial class LocationListView : Form
    {
        private LocationListViewModel _viewModel = new LocationListViewModel();
        public LocationListView()
        {
            InitializeComponent();

            LocationDataGrid.DataBindings.Add(
                "DataSource", _viewModel, nameof(_viewModel.Locations));

            this.LocationIdTextBox.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.NewLocationId));
            this.LocationNameTextBox.DataBindings.Add(
                "Text", _viewModel, nameof(_viewModel.NewLocationName));
        }

        private void LocationAddButton_Click(object sender, EventArgs e)
        {
            _viewModel.Save();
            _viewModel.ClearText();
        }
    }
}
