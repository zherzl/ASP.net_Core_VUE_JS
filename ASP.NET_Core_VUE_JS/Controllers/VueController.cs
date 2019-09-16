using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Model.Repositories;
using Gallery.Services.Interfaces;
using Gallery.Services.Messaging.Messaging.CarsService.Get;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Core.Infrastructure.ServiceProviderExtensions;

namespace Gallery.Controllers
{
  public class VueController : BaseController
  {
    ICarService _carService;

    public VueController(IServiceProvider serviceProvider) : base(serviceProvider)
    {
      _carService = base.ServiceProvider.GetService<ICarService>();
    }

    public IActionResult Index()
    {

      var cars =  _carService.GetAllCars(new GetAllCarsRequest());

      GetCarsByConditionRequest request = new GetCarsByConditionRequest();
      var response = _carService.GetCarsByCondition(request);

      ViewBag.error = "Greška:" + response.Message;
      return View();
    }

    //public IActionResult Error()
    //{
    //  return View (new ErrorViewModel())
    //}

  }
}
