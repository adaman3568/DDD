using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObject.CarEntity
{
    class FirstRegist:ValueObjectBase<FirstRegist>
    {
        public FirstRegist(DateTime value)
        {
            Value = value;
        }

        public DateTime Value { get; }

        protected override bool EqualCore(FirstRegist other)
        {
            return Value == other.Value;
        }
    }
}
