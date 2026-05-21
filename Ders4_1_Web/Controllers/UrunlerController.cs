using Microsoft.AspNetCore.Mvc;
using Ders4_1_BLL.Servis;
using Ders4_1_DLL.EntitiesTablolar;

namespace Ders4_1_Web.Controllers
{
    public class UrunlerController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string adi, int stok, decimal fiyat)
        {
            UrunServis urunServis = new UrunServis();//BLL
            //eklenecek ürün bilgilerini aşağıdaki gibi tanımlıyoruz
            Urunler ekleUrun = new Urunler();//DLL
            ekleUrun.Adi = adi;// "Monitor";
            ekleUrun.Stok = stok;//10;
            ekleUrun.Fiyat = fiyat;//15045;
            //eklenecek ürün bilgileri BLL katmanındaki Servis  yapısında tanımlanan UrunEkle metoduna gönderilir ve ekleme işlemi gerçekleştirilir/sorgulanır.
            string sonuc = urunServis.UrunEkle(ekleUrun.Adi, ekleUrun.Stok, ekleUrun.Fiyat);
            ViewBag.sonuc = sonuc;//sonucun ekranda görüntülenebilmesi için ViewBag yapısına atılır.
            return View();
        }
    }
}
