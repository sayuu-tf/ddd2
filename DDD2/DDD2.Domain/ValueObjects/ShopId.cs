using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD2.Domain.ValueObjects
{
    public sealed class ShopId : ValueObject<ShopId>
    {
        public ShopId(int value)
        {
            Value = value;
        }

        public int Value { get; }

        protected override bool EqualsCore(ShopId other)
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
