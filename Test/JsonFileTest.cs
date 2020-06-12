using Core.Entities;
using Core.Repository;
using NUnit.Framework;
using System.Linq;

namespace Test
{
    [TestFixture]
    public class JsonFileTest
    {
        RepositoryBase repository;
        [SetUp]
        public void Setup()
        {
            repository = new RepositoryBase();
        }

        [Test, Order(1)]
        public void TestAddCar()
        {
            CarEntity car = new CarEntity(){
                Id = -1,
                Model = "",
                Brand = "",
                Year = 0,
                Kilometers = 0,
                Price = 0
            };
            var elements = repository.GetAll();
            var newCarAdded = repository.Create(car);
            Assert.AreEqual(elements.Count + 1, newCarAdded.Count);
        }
        [Test, Order(2)]
        public void updateCar()
        {
            CarEntity car = new CarEntity()
            {
                Id = 0,
                Model = "Mazda",
                Brand = "",
                Year = 0,
                Kilometers = 0,
                Price = 0
            };
            var elements = repository.update(car);
            var element = elements.FirstOrDefault(c => c.Model.Equals("Mazda"));
            Assert.AreEqual("Mazda", element.Model);
        }
        [Test, Order(3)]
        public void findCar()
        {
            var car = repository.Get(0);
            Assert.AreEqual(car.Model, "Mazda");
        }
        [Test, Order(4)]
        public void getCars()
        {
            var elements = repository.GetAll();
            Assert.AreNotEqual(elements, null);
        }
        [Test, Order(5)]
        public void removeCar()
        {
            var initialElements = repository.GetAll();
            var finalElements = repository.delete(0);
            Assert.AreEqual(initialElements.Count - 1, finalElements.Count);

        }
    }
}