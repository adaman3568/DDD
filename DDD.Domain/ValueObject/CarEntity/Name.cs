using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObject.CarEntity
{
    public sealed class Name:ValueObjectBase<Name>
    {
        public Name(string value)
        {
            Value = value;
        }

        public string Value { get; set; }

        protected override bool EqualCore(Name other)
        {
            return Value == other.Value;
        }
    }
}
