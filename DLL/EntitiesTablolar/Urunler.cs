namespace DLL.EntitiesTablolar;

public  class Urunler
{
    public int Id { get; set; }
    public string Adi { get; set; }
    public int Stok { get; set; }
    public decimal Fiyat { get; set; }
    public string Aciklama { get; set; }
    public DateTime EklemeTarihi { get; set; }

    public int KategoriId { get; set; }
    //bağlama (Diagram-relation) işlemleri
    //1 ürünün 1 tane kategorisi vardır
    public Kategoriler Kategoriler { get; set; }


}

