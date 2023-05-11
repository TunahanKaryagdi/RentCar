using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {

        ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;   
        }


        [HttpGet("getall")]
        public IDataResult<List<Car>> GetCars()
        {
            return _carService.GetAll();
        }


    }
}
