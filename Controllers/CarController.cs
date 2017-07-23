using System;
using Microsoft.AspNetCore.Mvc;
using WebAPISample.Data;

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    public class CarController : Controller
    {
        private readonly ICarData _carData;
        public CarController(ICarData carData)
        {
            _carData = carData;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok( _carData.Get());
        }
    }
}