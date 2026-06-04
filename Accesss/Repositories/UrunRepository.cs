using Accesss.Repositories.Interfaces;
using DLL;
using DLL.EntitiesTablolar;

namespace Accesss.Repositories;

public class UrunRepository : GenericRepository<Urunler>, IUrunRepository
{
    public UrunRepository(HepsiNerdeDB hepsiNerdeDB) : base(hepsiNerdeDB) { }

    public List<Urunler> EnCokKalanUrunler()
    {
        throw new NotImplementedException();
    }

}
