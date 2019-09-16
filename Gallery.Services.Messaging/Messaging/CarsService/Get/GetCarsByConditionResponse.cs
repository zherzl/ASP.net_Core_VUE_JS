using Core.Model.ViewModels.CarViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Services.Messaging.Messaging.CarsService.Get
{
    public class GetCarsByConditionResponse : ResponseBase
    {
        public GetCarsByConditionResponse()
        {
            Cars = new List<CarVM>();
        }
        public List<CarVM> Cars { get; set; }
    }
}
