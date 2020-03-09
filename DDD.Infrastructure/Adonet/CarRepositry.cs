using System;
using System.Collections.Generic;
using System.Text;
using DDD.Domain.Entities;
using DDD.Domain.Repositry;

namespace DDD.Infrastructure.Ado.net
{
    class CarRepositry:ICarRepositry
    {
        public CarRepositry()
        {
        }

        public CarEntity Search(int id)
        {
            using (var db = new DDDStudyContext)
            {
                
            }



        }
    }
}
