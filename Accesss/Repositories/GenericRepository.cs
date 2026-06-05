
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
        _hepsiNerdeDB.Set<TEntityTablo>().Add(tablo);//EF ile yapılan bu işlem eklemek için son işlemdir. DB ye Add ile kayıt ekleneceğini bildirir
        _hepsiNerdeDB.SaveChanges();//EF ile yapılan bu işlem eklenen kayıtların db ye yansımasını sağlar
    }

    public void Guncelle(TEntityTablo tablo)
    {
        _hepsiNerdeDB.Set<TEntityTablo>().Entry(tablo).State = EntityState.Modified;//EF ile yapılan bu işlem güncellemek için son işlemdir. DB ye Update ile kayıt güncelleneceğini bildirir
        _hepsiNerdeDB.SaveChanges();//EF ile yapılan bu işlem güncellenen kayıtların db ye yansımasını sağlar
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

    public TEntityTablo GetirIdIle(int id)
    {
        var varmiData= _hepsiNerdeDB.Set<TEntityTablo>().Find(id);
        return varmiData;
    }
}
