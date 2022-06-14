using DDD2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Domain.Repositories
{
    public interface ILocationRepository
    {
        IReadOnlyList<LocationEntity> GetData();
    }
}
