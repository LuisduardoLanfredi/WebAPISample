using System;
using System.Collections.Generic;
using WebAPISample.Model;

namespace WebAPISample.Data
{
    public interface ICarData
    {
        ICollection<Car> Get();   
    }
}