﻿using Business.Abstract;
using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
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
        public IResult Add([FromHeader] IFormFile file, [FromForm] int carId)
        {

            CarImage carImage = new CarImage() { CarId = carId};
            var result = _carImageService.Add(file, carImage, carId);
            return result;

        }
    }
}
