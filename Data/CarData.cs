using System;
using System.Collections.Generic;
using WebAPISample.Model;

namespace WebAPISample.Data
{
    public class CarData : ICarData
    {
        private ICollection<Car> Cars;

        public CarData()
        {
            Cars = new List<Car>();
            Cars.Add(new Car(){ Id = 1, Name = "Fusca" });
            Cars.Add(new Car(){ Id = 2, Name = "Marea" });
            Cars.Add(new Car(){ Id = 3, Name = "Golf" });
            Cars.Add(new Car(){ Id = 4, Name = "Polo" });
        }

        public ICollection<Car> Get()
        {
            return Cars;
        }
    }
}