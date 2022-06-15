using DDD2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.WinForm.ViewModel
{
    public sealed class LocationListViewModelLocation: ViewModelBase
    {
        private LocationEntity _entity;
        public LocationListViewModelLocation(LocationEntity entity)
        {
            _entity = entity;
        }

        public string LocationId => _entity.LocationId.DisplayValue;
        public string LocationName => _entity.LocationName;
    }
}
