using DLL.EntitiesTablolar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DLL.Configurations;

internal class KategoriConfiguration : IEntityTypeConfiguration<Kategoriler>
{
    public void Configure(EntityTypeBuilder<Kategoriler> builder)
    {
        
        builder.HasKey(x => x.Id);//PK
        builder.Property(x => x.Id).UseIdentityColumn();//SQL de Increment, Seed ayarlarını 1,1 yapar
        builder.Property(x => x.Adi).IsRequired().HasMaxLength(250);
    }
}
