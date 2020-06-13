using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;

namespace TSF.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        public CarController(ICarService carService)
        {
            _carService = carService;
            _carService.makeSeed();
        }
        public IActionResult Create()
        {
            return View(new CarEntity());
        }
        [HttpGet]
        public IActionResult List()
        {
            return View(_carService.GetAll());
        }
        public IActionResult Update(int carId, string carModel, string carDesc, string brand, int kil, decimal price, int year)
        {
            var car = new CarEntity()
            {
                Id = carId,
                Model = carModel,
                Description = carDesc,
                Brand = brand,
                Kilometers = kil,
                Price = price,
                Year = year
            };
            return View(car);
        }
        public IActionResult Delete(int car)
        {
            var deletedCar = _carService.DeleteCar(car);
            return View("List", deletedCar);
        }
        [HttpPost]
        public ActionResult SendInformation([FromForm] CarEntity car)
        {
            if (!ModelState.IsValid)
                return View("Create");

            var response = _carService.CreateCar(car);
            return View("List", response);
        }
        public IActionResult UpdateInformation(CarEntity car)
        {
            if (!ModelState.IsValid)
                return View("Update", car);

            var updatedCarsList = _carService.UpdateCar(car);
            return View("List", updatedCarsList);
        }
        public List<CarEntity> readCars()
        {
            var jsonData = System.IO.File.ReadAllText(@"C:\Users\pepti\source\repos\ProjectTSF\TSF\wwwroot\JsonData\json.txt");
            var carsList = JsonConvert.DeserializeObject<List<CarEntity>>(jsonData);
            return carsList;
        }
    }
}
