using System;
using DDD.Domain.Entities;

namespace DDD.Domain.Repositry
{
    public interface ICarRepositry
    {
        CarEntity Search(int id);
    }
}