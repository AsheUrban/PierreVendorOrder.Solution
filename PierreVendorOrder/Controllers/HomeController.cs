using Microsoft.AspNetCore.Mvc;


namespace PierreVendorOrder.Controllers
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