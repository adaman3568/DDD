using System;
using System.Collections.Generic;
using System.Text;
using DDD.Domain.ValueObject.CarEntity;

namespace DDD.Domain.Entities
{
    public class CarEntity
    {
        public CarEntity(
            int id,
            string name,
            int rundist,
            DateTime firstregist,
            int enginetype,
            int inspection,
            int isrepair
        )
        {
            Id = id;
            Name = new Name(name);
            RunDist = new RunDist(rundist);
            FirstRegist = new FirstRegist(firstregist);
            EngineType = new EngineType(enginetype);
            Inspection = new Inspection(inspection);
            IsRepair = new IsRepair(isrepair);
        }

        public int Id { get; }
        public Name Name { get; }
        public RunDist RunDist { get; }
        public FirstRegist FirstRegist { get; }
        public EngineType EngineType { get; }
        public Inspection Inspection { get; }
        public IsRepair IsRepair { get; }
    }
}
