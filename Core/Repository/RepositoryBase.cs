using Core.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace Core.Repository
{
    public class RepositoryBase : IRepositoryBase
    {
        private string path = @"..\TSF\wwwroot\JsonData\json.txt";
        public List<CarEntity> Create(CarEntity newCar)
        {
            var carList = GetAll();
            int lastId;
            lastId = (carList.Count == 0)? 0 : carList.LastOrDefault().Id;
            newCar.Id = ++lastId;
            carList.Add(newCar);
            writeToDisk(carList);
            return carList;
        }

        public List<CarEntity> delete(int car)
        {
            var deletedCar = GetAll();
            deletedCar.RemoveAll(c => c.Id.Equals(car));
            writeToDisk(deletedCar);
            return deletedCar;
        }

        public CarEntity Get(int id)
        {
            var elements = GetAll();
            return elements.FirstOrDefault(c => c.Id.Equals(id));
        }

        public List<CarEntity> GetAll()
        {
            if (!File.Exists(path))
            {
                createNewFileIfNotExist();
            }
            var jsonData = File.ReadAllText(path);
            var carsList = JsonConvert.DeserializeObject<List<CarEntity>>(jsonData);
            return carsList;
        }

        public List<CarEntity> update(CarEntity car)
        {
            var updatedCarsList = GetAll();
            foreach (var c in updatedCarsList.Where(c => c.Id.Equals(car.Id)))
            {
                c.Brand = car.Brand;
                c.Description = car.Description;
                c.Kilometers = car.Kilometers;
                c.Model = car.Model;
                c.Price = car.Price;
                c.Year = car.Year;
            }
            writeToDisk(updatedCarsList);
            return updatedCarsList;
        }
        private void writeToDisk(List<CarEntity> listOfCars)
        {
            if (!File.Exists(path))
            {
                createNewFileIfNotExist();
            }
            string jsonData = JsonConvert.SerializeObject(listOfCars, Formatting.None);
            File.WriteAllText(path, jsonData);
        }
        private void createNewFileIfNotExist()
        {
            using (StreamWriter wr = File.CreateText(path))
            {
                wr.WriteLine("[]");
            }
        }
    }
}
