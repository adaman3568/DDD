using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace DDD.Domain.ValueObject.CarEntity
{
    class IsRepair:ValueObjectBase<IsRepair>
    {
        public static readonly IsRepair FalseRepair = new IsRepair(0);
        public static readonly IsRepair TrueRepair = new IsRepair(1);

        public IsRepair(int value)
        {
            Value = value;
        }

        public int Value { get; }

        public string DisplayValue
        {
            get
            {
                if (this == TrueRepair)
                {
                    return "修復歴あり";
                }
                else
                {
                    return "修復歴なし";
                }
            }
        }

        protected override bool EqualCore(IsRepair other)
        {
            return Value == other.Value;
        }
    }
}
