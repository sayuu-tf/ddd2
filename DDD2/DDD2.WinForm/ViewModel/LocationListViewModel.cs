using DDD2.Domain.Repositories;
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
    
        public LocationListViewModel(ILocationRepository location)
        {
            _location = location;

            foreach (var entity in _location.GetData())
            {
                Locations.Add(new LocationListViewModelLocation(entity));
            }
        }

        public BindingList<LocationListViewModelLocation> Locations { get; set; }
        = new BindingList<LocationListViewModelLocation>(); 
    }
}
