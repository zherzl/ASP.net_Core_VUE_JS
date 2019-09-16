using Gallery.Services.Messaging.Messaging.CarsService.Get;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gallery.Services.Interfaces
{
    public interface ICarService
    {
        GetAllCarsResponse GetAllCars(GetAllCarsRequest request);
        GetCarsByConditionResponse GetCarsByCondition(GetCarsByConditionRequest request);
    }
}
