using Microsoft.AspNetCore.Mvc;
using PierreVendorOrder.Models;

namespace PierreVendorOrder.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
  public ActionResult Index()
  {
    Order starterOrder = new Order("Add a New Order");
    return View(starterOrder);
  }
  }
}