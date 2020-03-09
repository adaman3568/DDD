using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Text;

namespace DDD.Domain.ValueObject.CarEntity
{
    class EngineType:ValueObjectBase<EngineType>
    {

        /// <summary>
        /// 不明
        /// </summary>
        public static readonly EngineType UnKnown = new EngineType(0);

        /// <summary>
        /// ハイブリッドエンジン
        /// </summary>
        public static readonly EngineType Hybrid = new EngineType(1);

        /// <summary>
        /// 通常エンジン（レギュラー・ハイオク）
        /// </summary>
        public static readonly EngineType Normal = new EngineType(2);

        /// <summary>
        /// ディーゼルエンジン
        /// </summary>
        public static readonly EngineType Diesel = new EngineType(3);

        public EngineType(int value)
        {
            Value = value;
        }

        public string DisplayValue
        {
            get
            {
                if (this == Hybrid)
                {
                    return "ハイブリッド";
                }else if (this == Normal)
                {
                    return "ガソリン";
                }
                else if(this == Diesel)
                {
                    return "ディーゼル";
                }

                return "不明";
            }
        }

        public int Value { get; }

        protected override bool EqualCore(EngineType other)
        {

            return Value == other.Value;
        }
    }
}
