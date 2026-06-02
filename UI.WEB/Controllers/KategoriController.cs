using Microsoft.AspNetCore.Mvc;

namespace UI.WEB.Controllers;

public class KategoriController : Controller
{

    [HttpGet]
    public IActionResult List()
    {
        return View();
    }


    [HttpGet]
    public IActionResult Ekle()
    {
        return View();
    }
}
