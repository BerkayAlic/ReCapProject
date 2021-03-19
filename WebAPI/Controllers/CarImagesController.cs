using Business.Abstract;
using Business.Constants;
using Entities.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        ICarImageService _carImageservice;
        public static IWebHostEnvironment _environment;

        public CarImagesController(ICarImageService carImageService, IWebHostEnvironment environment)
        {
            _carImageservice = carImageService;
            _environment = environment;
            
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {

            var result = _carImageservice.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _carImageservice.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add([FromForm]CarImage carImage, [FromForm] IFormFile file)
        {
            string newNameOfImage = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
            string filePath = _environment.WebRootPath + @"\\Images\\";

            if (Path.GetExtension(file.FileName) != ".jpg" && (Path.GetExtension(file.FileName) != ".png"))
            {
                return BadRequest("FileExtensionIsNotCorrect");
            }

            carImage.ImagePath = newNameOfImage + filePath;
            var result = _carImageservice.Add(carImage, file);

            if (result.Success)
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                using (FileStream fileStream = System.IO.File.Create(filePath + newNameOfImage))
                {
                    file.CopyTo(fileStream);
                    fileStream.Flush();
                }
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(CarImage carImage)
        {
            var result = _carImageservice.Delete(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(CarImage carImage)
        {
            var result = _carImageservice.Update(carImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        //[HttpPost("add2")]
        //public IActionResult add2(CarImage carImage)
        //{
        //    var result = _carImageservice.Add(carImage, file);
        //    if (result.Success)
        //    {
        //        return Ok(result);
        //    }
        //    return BadRequest(result);
        //}


        [HttpGet("getbycarid")]
        public IActionResult GetByCarId(int id)
        {
            var result = _carImageservice.GetByCarId(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }

}