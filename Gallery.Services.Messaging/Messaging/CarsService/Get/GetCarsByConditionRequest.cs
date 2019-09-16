using System;
using System.Collections.Generic;
using System.Text;

namespace Gallery.Services.Messaging.Messaging.CarsService.Get
{
    public class GetCarsByConditionRequest : GetRequestBase
    {
        public int CarManufacturerId { get; set; }
    }
}
