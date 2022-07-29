using Business.Abstract;
using Business.Constants;
using Core.Business;
using Core.Utilities.Helpers.FileHelper;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _icarImageDal;
        IFileHelper _iFileHelper;

        public CarImageManager(ICarImageDal icarImageDal, IFileHelper iFileHelper)
        {
            _icarImageDal = icarImageDal;
            _iFileHelper = iFileHelper;
        }
        public IResult Add(IFormFile file, CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageLimit(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = _iFileHelper.Upload(file, PathConstants.ImagesPath);
            carImage.Date= DateTime.Now;

            _icarImageDal.Add(carImage);
            return new SuccessResult(Messages.CarAdded);
        }


        public IResult Delete(CarImage carImage)
        {
            _iFileHelper.Delete(PathConstants.ImagesPath + carImage.ImagePath);
            _icarImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_icarImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            var result = BusinessRules.Run(CheckCarImage(carId));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(GetDefaultImage(carId).Data);
            }
            return new SuccessDataResult<List<CarImage>>(_icarImageDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<CarImage> GetByImageId(int imageId)
        {
            return new SuccessDataResult<CarImage>(_icarImageDal.Get(c => c.Id == imageId));
        }


        public IResult Update(IFormFile file, CarImage carImage)
        {
           carImage.ImagePath = _iFileHelper.Update(file,PathConstants.ImagesPath +carImage.ImagePath,PathConstants.ImagesPath);
            _icarImageDal.Update(carImage);
            return new SuccessResult(Messages.CarUpdated);
        }
        //BusinessRules
        private IResult CheckIfCarImageLimit(int carId)
        {
            var result = _icarImageDal.GetAll(c => c.CarId == carId).Count;
            if (result >= 5)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }
        private IDataResult<List<CarImage>> GetDefaultImage(int carId)
        {

            List<CarImage> carImage = new List<CarImage>();
            carImage.Add(new CarImage { CarId = carId, Date = DateTime.Now, ImagePath = "DefaultImage.jpg" });
            return new SuccessDataResult<List<CarImage>>(carImage);
        }
        private IResult CheckCarImage(int carId)
        {
            var result = _icarImageDal.GetAll(c => c.CarId == carId).Count;
            if (result > 0)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }

    }

}
