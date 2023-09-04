using Microsoft.AspNetCore.Mvc;

namespace FoxicUI.Areas.Admin.Controllers;
[Area("Admin")]

public class ProductController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
