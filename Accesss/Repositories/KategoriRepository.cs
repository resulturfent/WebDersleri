using Accesss.Repositories.Interfaces;
using DLL.EntitiesTablolar;

namespace Accesss.Repositories;

public class KategoriRepository : GenericRepository<Kategoriler>, IKategoriRepository
{
    public int KategoriyeGoreUrunSayisi(int kategoriId)
    {
        throw new NotImplementedException();
    }
}
