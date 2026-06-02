using DLL.Base;

namespace DLL.EntitiesTablolar;

public class Kategoriler:BaseTablo
{
    public string Adi { get; set; }
    //1 kategoride 1'den fazla ürün vardır, bu durumda bağlantı için ürünleri 1'den fazla getirecek şekilde bağlamamız gerekli
    //
    public  ICollection<Urunler> Urunler =new List<Urunler>();

}
