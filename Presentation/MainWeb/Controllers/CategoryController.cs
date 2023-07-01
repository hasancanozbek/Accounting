using Microsoft.AspNetCore.Mvc;

namespace MainWeb.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CategoryIndex()
        {
            return View("Index");
        }
    }
}
