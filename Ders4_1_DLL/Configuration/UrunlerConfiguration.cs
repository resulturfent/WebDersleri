using Ders4_1_DLL.EntitiesTablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ders4_1_DLL.Configuration;

public class UrunlerConfiguration : IEntityTypeConfiguration<Urunler>
{
    public void Configure(EntityTypeBuilder<Urunler> builder)
    {        
        builder.HasKey(x => x.Id);//HasKey=> PK olduğunu gösterir
        builder.Property(k => k.Id);//.UseIdentityColumn();//UseIdentityColumn=> Identity kolon olduğunu gösterir, yani otomatik artan bir kolon olduğunu belirtir.
        builder.Property(k=>k.Adi).IsRequired(true).HasMaxLength(250);//HasMaxLength(50)=> 50 karakterden fazla girişi engeller
        builder.Property(k => k.Stok).IsRequired(true);//IsRequired(true)=> true girişi zorunlu, boş geçilemez anlamına gelir, false girişi ise boş geçilebilir anlamına gelir.
        builder.Property(k => k.Fiyat).IsRequired(true);//.HasDefaultValue("decimal(18,2)");
        builder.Property(k => k.Aciklama).IsRequired(false).HasMaxLength(500);

    }
}
