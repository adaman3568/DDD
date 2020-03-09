using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObject.CarEntity
{
    class Inspection:ValueObjectBase<Inspection>
    {
        public static readonly Inspection Has = new Inspection(0);
        public static readonly Inspection NotHas = new Inspection(1);

        public Inspection(int value)
        {
            Value = value;
        }

        public string DisplayValue
        {
            get
            {
                if (this == Has)
                {
                    return "車検付き";
                }
                else
                {
                    return "車検なし";
                }
            }
        }

        public int Value { get; }
        protected override bool EqualCore(Inspection other)
        {
            return Value == other.Value;
        }
    }
}
