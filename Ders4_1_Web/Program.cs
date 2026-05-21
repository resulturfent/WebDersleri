using Ders4_1_BLL.Servis;
using Ders4_1_DLL;
using Ders4_1_DLL.EntitiesTablolar;

namespace Ders4_1_Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<Urunler>();
            builder.Services.AddScoped<UrunServis>();

            builder.Services.AddSqlServer<HepsiNerdeDB>(builder.Configuration.GetConnectionString("HepsiNerdeDBAdres"));
            //HepsiNerdeDBAdres=> appsettings.json dosyasında tanımlanan bağlantı dizesinin adıdır. Bu ad, veritabanına bağlanmak için gerekli olan bilgileri içerir (örneğin, sunucu adı, veritabanı adı, kullanıcı adı, şifre vb.). Bu bağlantı dizesi, Entity Framework Core'un HepsiNerdeDB bağlamını yapılandırmak için kullanılır ve veritabanına erişim sağlar.

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
