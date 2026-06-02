
using Accesss.Repositories.Interfaces;

namespace Accesss.Repositories;

public class GenericRepository<TEntityTablo> : IGenericRepository<TEntityTablo> where TEntityTablo : class
{
    public void Ekle(TEntityTablo tablo)
    {
        throw new NotImplementedException();
    }

    public void Guncelle(TEntityTablo tablo)
    {
        throw new NotImplementedException();
    }

    public List<TEntityTablo> HepsiniListele()
    {
        throw new NotImplementedException();
    }

    public void Sil(int id)
    {
        throw new NotImplementedException();
    }
}
