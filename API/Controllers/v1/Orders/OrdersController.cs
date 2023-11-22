using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.v1.Orders
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
