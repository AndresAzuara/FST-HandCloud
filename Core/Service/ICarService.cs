using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public interface ICarService
    {
        List<CarEntity> CreateCar(CarEntity car);
        IEnumerable<CarEntity> GetAll();
        CarEntity GetById(CarEntity car);
        List<CarEntity> UpdateCar(CarEntity car);
        List<CarEntity> DeleteCar(int car);
        void makeSeed();
    }
}
