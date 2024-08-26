using Microsoft.AspNetCore.Mvc;

namespace ConsCedHadaPLT.Controllers
{
    public class CedulasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
