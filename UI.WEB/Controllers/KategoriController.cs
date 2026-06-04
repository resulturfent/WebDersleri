using BLL.Services;
using BLL.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace UI.WEB.Controllers;

public class KategoriController : Controller
{

    private readonly IKategoriService _kategoriService;//newlemeden kullanma biçimi


    public KategoriController(IKategoriService kategoriService)
    {
        _kategoriService = kategoriService;
    }


    [HttpGet]
    public IActionResult List()
    {
        var list = _kategoriService.List();
        return View(list);
    }


    [HttpGet]
    public IActionResult Ekle()
    {
        return View();
    }
}
