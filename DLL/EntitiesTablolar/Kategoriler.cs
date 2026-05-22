namespace DLL.EntitiesTablolar;

public class Kategoriler
{
    public int Id { get; set; }
    public string Adi { get; set; }
    //1 kategoride 1'den fazla ürün vardır, bu durumda bağlantı için ürünleri 1'den fazla getirecek şekilde bağlamamız gerekli
    //
    public  ICollection<Urunler> Urunler =new List<Urunler>();

}
