using Accesss.Repositories.Interfaces;
using DLL.EntitiesTablolar;

namespace Accesss.Repositories;

public class UrunRepository : GenericRepository<Urunler>, IUrunRepository
{
    public List<Urunler> EnCokKalanUrunler()
    {
        throw new NotImplementedException();
    }
}
