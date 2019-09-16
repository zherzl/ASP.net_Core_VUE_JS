using Core.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Services.Messaging.Messaging.CarsService.Get
{
    public class GetAllCarsResponse : ResponseBase
    {
        public List<Car> Cars { get; set; }
    }
}
