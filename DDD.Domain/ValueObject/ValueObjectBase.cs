using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Domain.ValueObject
{
    public abstract class ValueObjectBase<T> where T:ValueObjectBase<T>
    {
        public override bool Equals(object obj)
        {
            var vo = obj as T;
            if (vo == null)
            {
                return false;
            }

            return EqualCore(vo);
        }

        public static bool operator ==(ValueObjectBase<T> vo1, ValueObjectBase<T> vo2)
        {
            return Equals(vo1, vo2);
        }

        public static bool operator !=(ValueObjectBase<T> vo1, ValueObjectBase<T> vo2)
        {
            return !Equals(vo1, vo2);
        }

        protected abstract bool EqualCore(T other);
    }
}
