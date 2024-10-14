
using Microsoft.AspNetCore.Mvc;

namespace ipt.Controllers
{
    public class ItalyController : Controller
    {
        // GET: Home/Index
        public IActionResult Italy()
        {
            return View();
        }

        public IActionResult NotFoundPage()
        {
            return View();
        }
    }
}
