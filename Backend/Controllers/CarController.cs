using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Entities;
using Backend.Repositories;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private ICarRepository carRepository = null;
        
        public CarController(ICarRepository carRepository)
        {
            this.carRepository = carRepository;
        }

        [HttpGet]
        [Route("CarSummary")]
        public IActionResult CarSummary()
        {
            List<Car> cars =  this.carRepository.CarSummary();
            return Ok(cars);
        }

        [HttpDelete]
        [Route("RemoveCar/{model}")]
        public IActionResult RemoveCar(string model)
        {
            this.carRepository.RemoveCar(model);
            return Ok("Car Removed");
        }

        [HttpGet]
        [Route("SearchCar/{model}")]
        public IActionResult SearchCar(string model)
        {
            Car car = this.carRepository.SearchCar(model);
            if (car != null)
                return Ok(car);
            else
                return Content("Invalid Model");
        }

        [HttpPost]
        [Route("AddCar")]
        public IActionResult AddCar(Car car)
        {
            this.carRepository.AddCar(car);
            return Ok("Product Added");
        }

        [HttpPut]
        [Route("UpdateCar")]
        public IActionResult UpdateCar(Car car)
        {
            this.carRepository.UpdateCar(car);
            return Ok("Car Updated");
        }
        
    }
}
