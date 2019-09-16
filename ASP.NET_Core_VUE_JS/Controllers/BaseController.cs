using Microsoft.AspNetCore.Mvc;
using System;

namespace Gallery.Controllers
{
  public abstract class BaseController : Controller
  {
    public IServiceProvider ServiceProvider { get;  }
    public BaseController(IServiceProvider serviceProvider)
    {
      this.ServiceProvider = serviceProvider;
    }

    public BaseController()
    {
      
    }


  }
}
