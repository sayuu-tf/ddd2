using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Domain.ValueObjects
{
    public sealed class LocationId : ValueObject<LocationId>
    {
        public LocationId(int value)
        {
            Value = value;
        }

        public int Value { get; }

        protected override bool EqualsCore(LocationId other)
        {
            return Value == other.Value;
        }

        public string DisplayValue
        {
            get
            {
                return Value.ToString().PadLeft(4, '0');
            }
        }
    }
}
