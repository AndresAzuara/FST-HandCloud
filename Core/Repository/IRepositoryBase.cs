using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.Repository
{
    public interface IRepositoryBase
    {
        List<CarEntity> Create(CarEntity newCar);
        List<CarEntity> GetAll();
        CarEntity Get(int id);
        List<CarEntity> update(CarEntity car);
        List<CarEntity> delete(int car);
    }
}
