using DLL.EntitiesTablolar;

namespace BLL.Services.IServices;

public interface IKategoriService
{
    public Kategoriler Ekle(Kategoriler kategoriler);
    public List<Kategoriler> List();
    public Kategoriler GetirIdIle(int id);
    public Kategoriler Guncelle(int id, string adi);

}
