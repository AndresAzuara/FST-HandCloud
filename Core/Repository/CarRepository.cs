using Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repository
{
    public class CarRepository : RepositoryBase, ICarRepository
    {
        public List<CarEntity> CreateCar(CarEntity car)
        {
            var response = Create(car);
            return response;
        }

        public List<CarEntity> DeleteCar(int car)
        {
            var response = delete(car);
            return response;
        }

        public IEnumerable<CarEntity> Get()
        {
            var response = GetAll();
            return response;
        }

        public CarEntity GetById(CarEntity car)
        {
            throw new NotImplementedException();
        }

        public List<CarEntity> UpdateCar(CarEntity car)
        {
            var response = update(car);
            return response;
        }
        
    }
}
