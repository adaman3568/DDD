using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObject.CarEntity
{
    class RunDist:ValueObjectBase<RunDist>
    {
        public RunDist(float value)
        {
            Value = value;
        }

        public float Value { get; }

        protected override bool EqualCore(RunDist other)
        {

            return Value == other.Value;

        }
    }
}
