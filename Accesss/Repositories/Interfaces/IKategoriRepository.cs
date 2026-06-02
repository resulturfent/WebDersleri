using DLL.EntitiesTablolar;

namespace Accesss.Repositories.Interfaces;

public interface IKategoriRepository:IGenericRepository<Kategoriler>
{
    public int KategoriyeGoreUrunSayisi(int kategoriId);
}
