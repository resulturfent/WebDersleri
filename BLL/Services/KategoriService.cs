using Accesss.Repositories;
using Accesss.Repositories.Interfaces;
using BLL.Services.IServices;
using DLL.EntitiesTablolar;

namespace BLL.Services;

public class KategoriService : IKategoriService
{
    private readonly IKategoriRepository _kategoriRepository;//DI

    public KategoriService(IKategoriRepository kategoriRepository)
    {
        //DI
        _kategoriRepository = kategoriRepository;
    }

    //private readonly IKategoriRepository _kategoriRepository1=new KategoriRepository();//_kategoriRepository1 bir Garbage Collector nesnesidir, çünkü new'lediğimiz için bellekte yer kaplar ama kullanmayacağımız için çöp olur.

    public Kategoriler Ekle(Kategoriler kategoriler)
    {
        Kategoriler ekle = new Kategoriler();//boş bir kategori nesnesi oluşturduk.

        ekle.Adi = kategoriler.Adi;
        ekle.EklenmeTarihi = DateTime.Now;
        ekle.EkleyenId = 1;//şimdilik ekleyen id'sini 1 yapıyoruz.
        //_kategoriRepository1.Ekle(ekle);//kategori ekleme işlemi yapıyoruz ama garbage collector nesnesi olduğu için kullanmıyoruz. Sadece örnek için tanımladık, gerçek uygulamada kullanmayacağız.
        _kategoriRepository.Ekle(ekle);//kategori ekleme işlemi yapıyoruz.

        return ekle;

    }
}
