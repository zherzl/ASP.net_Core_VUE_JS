using Core.Model.Models;
using Core.Model.Repositories;
using Gallery.Services.Interfaces;
using Gallery.Services.Messaging.Messaging.CarsService.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Services.Implementations
{
    public class CarService : ICarService
    {
        private readonly ICarsRepository _carsRepo;
        private readonly IAppUserRepository _usersRepo;

        public CarService
            (
            ICarsRepository _carsRepo,
            IAppUserRepository _usersRepo
            )
        {
            this._carsRepo = _carsRepo;
            this._usersRepo = _usersRepo;
        }

        public GetAllCarsResponse GetAllCars(GetAllCarsRequest request)
        {
            GetAllCarsResponse response = new GetAllCarsResponse();

            try
            {
                response.Cars = _carsRepo.GetAll().ToList();
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }

        public GetCarsByConditionResponse GetCarsByCondition(GetCarsByConditionRequest request)
        {
            GetCarsByConditionResponse response = new GetCarsByConditionResponse();

            try
            {
                //response.Cars = _carsRepo.Get()
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
