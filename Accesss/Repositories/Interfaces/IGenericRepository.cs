namespace Accesss.Repositories.Interfaces;

public interface  IGenericRepository<TEntityTablo> where TEntityTablo : class
{
    //DI=> Dependency Injection=> Interface üzerinde tanımlanan operasyonların somut sınıflar tarafından implemente edilmesidir.
    //DI Garbage Collector tarafından yönetilen bir bellek yönetimi tekniğidir. New'lenerek çağırmak yerine ctor ile new'lemeden çağırmayı sağlar.
    //Devamı uygulama içerisinde görülecektir.?????????????????????????????

    public List<TEntityTablo> HepsiniListele();
    public void Ekle(TEntityTablo tablo);
    public void Guncelle(TEntityTablo tablo);
    public void Sil(int id);

}
