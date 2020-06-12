using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Core.Repository;

namespace Core.Service
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<CarEntity> CreateCar(CarEntity car)
        {
            var carCreated = _carRepository.CreateCar(car);
            return carCreated;
        }

        public List<CarEntity> DeleteCar(int car)
        {
            var deletedCar = _carRepository.DeleteCar(car);
            return deletedCar;
        }

        public IEnumerable<CarEntity> GetAll()
        {
            return _carRepository.Get();
        }

        public CarEntity GetById(CarEntity car)
        {
            throw new NotImplementedException();
        }

        public List<CarEntity> UpdateCar(CarEntity car)
        {
            var updatedCar = _carRepository.UpdateCar(car);
            return updatedCar;
        }
    }
}
