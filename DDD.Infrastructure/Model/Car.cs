using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Infrastructure.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float RunDist { get; set; }
        public DateTime FirstRegist { get; set; }
        public int EngineType { get; set; }
        public int Inspection { get; set; }
        public int IsRepair { get; set; }
    }
}
