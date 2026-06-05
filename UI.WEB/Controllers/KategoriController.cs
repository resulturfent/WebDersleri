using BLL.Services;
using BLL.Services.IServices;
using DLL.EntitiesTablolar;
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

    [HttpPost]
    public IActionResult Ekle(Kategoriler kategori)
    {
        var result = _kategoriService.Ekle(kategori);

        if (result != null)
        {
            return RedirectToAction("List");
        }
        ViewBag.error = "Kategori eklenirken bir hata oluştu.";
        return View();
    }


    [HttpGet]
    public IActionResult Guncelle(int id)
    {
        var kategori = _kategoriService.GetirIdIle(id);

        if (kategori == null)
        {
            return RedirectToAction("List");//List methoduna yönlendir RedirectToAction("List");
        }
        return View(kategori);
    }

    [HttpPost]
    public IActionResult Guncelle(int id, string adi)
    {
        var result = _kategoriService.Guncelle(id, adi);

        if (result != null)
        {
            return RedirectToAction("List");
        }
        return View();//??
    }

}
