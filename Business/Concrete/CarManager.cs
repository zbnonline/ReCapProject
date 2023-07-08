using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.DailyPrice < 0)
            {
                return new ErrorResult(Message.CarPriceIsNegative);
            }

            if (car.CarName.Length <= 2)
            {
                return new ErrorResult(Message.CarNameInValid);
            }

            _carDal.Add(car);

            return new SuccessResult(Message.AddedCar);
            
        }

        public IDataResult<List<CarDetailDto>> CarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Message.DeletedCar);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<Car> GetById(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.CarId == carId));
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId));
        }

        public IResult Update(Car car)
        {
            if (car.DailyPrice < 0)
            {
                return new ErrorResult(Message.CarPriceIsNegative);
            }

            if (car.CarName.Length <= 2)
            {
                return new ErrorResult(Message.CarNameInValid);
            }

            _carDal.Update(car);

            return new SuccessResult(Message.UpdatedCar);
        }
    }
}
