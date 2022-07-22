using Microsoft.AspNetCore.Mvc;

namespace Catalogue.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}
