using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface ICarRepository : IRepositoryBase
    {
        List<CarEntity> CreateCar(CarEntity car);
        IEnumerable<CarEntity> Get();
        void makeSeedToDisk();
        CarEntity GetById(CarEntity car);
        List<CarEntity> UpdateCar(CarEntity car);
        List<CarEntity> DeleteCar(int car);
    }
}
