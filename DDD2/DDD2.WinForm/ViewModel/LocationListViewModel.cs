using DDD2.Domain.Entities;
using DDD2.Domain.Repositories;
using DDD2.Infrastructure.SQLServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm.ViewModel
{
    public class LocationListViewModel: ViewModelBase
    { 
        private ILocationRepository _location;

        public LocationListViewModel()
            :this(new LocationSQLServer())
        {

        }

        public LocationListViewModel(ILocationRepository location)
        {
            _location = location;

            NewLocationName = String.Empty;

            foreach (var entity in _location.GetData())
            {
                Locations.Add(new LocationListViewModelLocation(entity));
            }
        }

        public BindingList<LocationListViewModelLocation> Locations { get; set; }
        = new BindingList<LocationListViewModelLocation>();
        public string _newLocationId = String.Empty;
        public string NewLocationId { get; set; }
        public string NewLocationName { get; set; }

        public void Save()
        {
            _location.Save(new LocationEntity(Convert.ToInt32(NewLocationId), NewLocationName));
        }

        public void ClearText()
        {
            NewLocationId = String.Empty;
            NewLocationName = String.Empty;
        }
    }
}
