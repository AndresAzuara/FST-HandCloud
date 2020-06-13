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

        public void makeSeed()
        {
            var information = GetAll();
            if(information.Count == 0 || information is null)
            {
                var seed = new List<CarEntity>()
                {
                    new CarEntity()
                    {
                        Id = 1,
                        Model = "Escape",
                        Brand = "Chevrolet",
                        Description = "Camioneta 4 puertas, 4 x 4",
                        Year = 2020,
                        Kilometers = 0,
                        Price = 200000
                    },
                    new CarEntity()
                    {
                        Id = 2,
                        Model = "3 Coupe",
                        Brand = "Mazda",
                        Description = "4 puertas, aire condicionado",
                        Year = 2019,
                        Kilometers = 0,
                        Price = 350000
                    },
                    new CarEntity()
                    {
                        Id = 3,
                        Model = "Beattle",
                        Brand = "Volks Waggen",
                        Description = "2 puertas, aire condicionado",
                        Year = 2015,
                        Kilometers = 200,
                        Price = 300000
                    },
                    new CarEntity()
                    {
                        Id = 4,
                        Model = "Tracker",
                        Brand = "Tracker",
                        Description = "4 puertas, aire condicionado, 4 x 4",
                        Year = 2002,
                        Kilometers = 1200,
                        Price = 70000
                    },
                    new CarEntity()
                    {
                        Id = 5,
                        Model = "Tsuru",
                        Brand = "Nissan",
                        Description = "4 puertas, sin aire condicionado",
                        Year = 2008,
                        Kilometers = 800,
                        Price = 80000
                    }
                };
                writeToDisk(seed);
            }
        }
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
