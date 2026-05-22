using DLL.EntitiesTablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLL.Configurations;

public class UrunConfiguration : IEntityTypeConfiguration<Urunler>
{
    public void Configure(EntityTypeBuilder<Urunler> builder)
    {
        builder.HasKey(x => x.Id);//HasKey=> PK olduğunu gösterir
        builder.Property(k => k.Id).UseIdentityColumn();//UseIdentityColumn=> Identity kolon olduğunu gösterir, yani otomatik artan bir kolon olduğunu belirtir.
        builder.Property(k => k.Adi).IsRequired(true).HasMaxLength(250);//HasMaxLength(50)=> 50 karakterden fazla girişi engeller
        builder.Property(k => k.Stok).IsRequired(true);//IsRequired(true)=> true girişi zorunlu, boş geçilemez anlamına gelir, false girişi ise boş geçilebilir anlamına gelir.
        builder.Property(k => k.Fiyat).IsRequired(true);//.HasDefaultValue("decimal(18,2)");
        builder.Property(k => k.Aciklama).IsRequired(false).HasMaxLength(500);


        // 1-Kategori , 1'den fazla(withMany) Ürün ile eşleşebilir
        // tablo arasında ilişkisel (relation) yapısını CodeFirst ile yapılması aşağıdak gibi olacaktır
        builder.HasOne(u => u.Kategoriler).WithMany(k => k.Urunler).HasForeignKey(u => u.KategorilerId);

        //HasForeignKey(h=>h.KategoriId)=> FK yapar
        //OnDelete(DeleteBehavior.Cascade)=> silinme durumunda bağlı olan ürünleri de siler. Silme işlemi kesinlikle olmayacaktır, pasif silme yapılacağında bu alanı kullanmıyacağız


    }
}
