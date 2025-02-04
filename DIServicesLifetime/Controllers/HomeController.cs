using DIServicesLifetime.Models;
using DIServicesLifetime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text;

namespace DIServicesLifetime.Controllers
{
    public class HomeController : Controller
    {
       
       private readonly IScoppedGuideService _Scopped1;
       private readonly IScoppedGuideService _Scopped2;

       private readonly ITransientGuideService _Transient1;
       private readonly ITransientGuideService _Transient2;
      
       private readonly ISingletoGuidService _Singleton1;
       private readonly ISingletoGuidService _Singleton2;
     

        public HomeController(IScoppedGuideService scopped1, IScoppedGuideService scopped2,
           ITransientGuideService Transient1, ITransientGuideService Transient2,
           ISingletoGuidService Singleton1, ISingletoGuidService Singleton2)
        {
              _Scopped1 = scopped1;
              _Scopped2 = scopped2;
            _Transient1 = Transient1;
            _Transient2 = Transient2;
            _Singleton1 = Singleton1;
            _Singleton2 = Singleton2;


        }

        public IActionResult Index()
        {
            StringBuilder messages = new StringBuilder();
            messages.Append($"Transient 1 : {_Transient1.getGuide()}\n");
            messages.Append($"Transient 2 : {_Transient2.getGuide()}\n\n\n");

            messages.Append($"Scopped 1 : {_Scopped1.getGuide()}\n");
            messages.Append($"Scopped 2 : {_Scopped2.getGuide()}\n\n\n");

            messages.Append($"Singleton 1 : {_Singleton1.getGuide()}\n");
            messages.Append($"Singleton 2 : {_Singleton2.getGuide()}\n\n\n");
            return Ok(messages.ToString());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
