using DDD2.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Domain.Entities
{
    public sealed class LocationEntity
    {
        public string LocationName { get; }
        public LocationId LocationId { get; }

        public LocationEntity(int locationId, string locationName)
        {
            LocationId = new LocationId(locationId);
            LocationName = locationName;
        }
    }
}
