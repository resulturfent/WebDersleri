using Ders4_1_DLL.EntitiesTablolar;

namespace Ders4_1_BLL.Servis;

public class UrunServis
{
    public string UrunEkle(string name, int stok, decimal fiyat)
    {
        //Urunler class'ını kullanmak için using olarak DLL katmanındaki (Library) EntitiesTablolar namespace'ini ekledik. Böylece Urunler class'ını kullanabiliriz.
        Urunler urunler = new Urunler();
        //DLL katmanında yer alan Urunler sınıfından bir nesne oluşturduk.
        //BLL katmaı kuralların , iş mantığını yazdığımız katmandır. Bu katmanda ürün ekleme işlemi için bazı kurallar yazabiliriz. Örneğin ürün adı boş olamaz, stok negatif/0 olamaz, fiyat negatif/0 olamaz gibi kurallar yazabiliriz.

        if (string.IsNullOrWhiteSpace(name))
        {
            return "ürün adı boş olamaz.";
        }
        if (stok <= 0)
        {
            return "stok negatif/0 olamaz.";
        }
        if (fiyat <= 0)
        {
            return "fiyat negatif/0 olamaz.";
        }
        return "Ürün ekleme işlemi yapıldı.";
    }
}
