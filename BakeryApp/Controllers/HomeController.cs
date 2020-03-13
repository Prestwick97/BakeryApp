using Microsoft.AspNetCore.Mvc;

namespace BakeryApp.Controllers
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