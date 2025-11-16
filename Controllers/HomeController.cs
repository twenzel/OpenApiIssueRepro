using Microsoft.AspNetCore.Mvc;

namespace OpenApiIssueRepro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
