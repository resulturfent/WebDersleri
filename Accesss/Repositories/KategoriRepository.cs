using Accesss.Repositories.Interfaces;
using DLL;
using DLL.EntitiesTablolar;

namespace Accesss.Repositories;

public class KategoriRepository : GenericRepository<Kategoriler>, IKategoriRepository
{
    public KategoriRepository(HepsiNerdeDB hepsiNerdeDB) : base(hepsiNerdeDB){}

    public int KategoriyeGoreUrunSayisi(int kategoriId)
    {

        var listKategori = _hepsiNerdeDB.Kategoriler.ToList();//KAtegoriler tablosnun tüm verilerini getirir

        throw new NotImplementedException();
    }

}
