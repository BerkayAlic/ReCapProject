using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetById(int Id);
        IResult Add(CarImage carImage, IFormFile file);
        IResult Delete(CarImage carImage);

        IResult Update(CarImage carImage);

        IDataResult<List<CarImage>> GetByCarId(int id);
    }
}
