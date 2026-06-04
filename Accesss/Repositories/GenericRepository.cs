
using Accesss.Repositories.Interfaces;
using DLL;
using Microsoft.EntityFrameworkCore;

namespace Accesss.Repositories;

public class GenericRepository<TEntityTablo> : IGenericRepository<TEntityTablo> where TEntityTablo : class
{
    protected readonly HepsiNerdeDB _hepsiNerdeDB;

    public GenericRepository(HepsiNerdeDB hepsiNerdeDB)
    {
        _hepsiNerdeDB = hepsiNerdeDB;
    }

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
        var list = _hepsiNerdeDB.Set<TEntityTablo>().ToList();//linq ile yazılmış kod yapısıdır. LINQ=> C# kodu içinde veriatabanı kodlarını(SQL)  kodlamaya yarayan bir teknolojidir
        //Migration işlemi Code-First için kullandığımız bir tabirdir. Code First bir ORM (Object Relation Mapping(Manager)) aracıdır. Ado.Net, Code Model, Db Model, Code First ORM araçlarıdır

        return list;
    }

    public void Sil(int id)
    {
        throw new NotImplementedException();
    }
}
