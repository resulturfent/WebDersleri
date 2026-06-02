using DLL.EntitiesTablolar;

namespace Accesss.Repositories.Interfaces;

public interface IUrunRepository: IGenericRepository<Urunler>
{
    public List<Urunler> EnCokKalanUrunler();


}
