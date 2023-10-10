using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using IResult = Core.Utilities.Results.IResult;

namespace WebAPI.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageService;
     
        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }


        [HttpPost("add")]
        public IActionResult Add(IFormFile file, [FromForm] int carId)
        {

            var carImage = new CarImage() { CarId = carId };
            var result = _carImageService.Add(file, carImage, carId);

            if (result.Success)
            {
                return Ok(result);
            }
            return  BadRequest(result);
        }


        [HttpGet("getall")]
        public IActionResult GetAll()
        {
           return Ok(_carImageService.GetAll());

        }

        [HttpGet("getimagesbycarid")]
        public IActionResult GetImagesByCarId(int carId)
        {
            var result = _carImageService.GetByCarId(carId);
            if (result.Success)
            {
                return Ok(result);   
            }
            return BadRequest(result);

        }
    }
}
