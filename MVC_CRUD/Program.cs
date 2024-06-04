using MVC_CRUD.IServices;
using MVC_CRUD.Services;

namespace MVC_CRUD
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Add DI (Dependency Injection)
            builder.Services.AddTransient<IMoneyServices, MoneyServices>();
            // Transient: Có vòng đời ngắn nhất, services sẽ được khởi tạo mỗi khi cần dùng và hẹo,
            // ít tốn tài nguyên nhất
            // Scope: Có vòng đời dài hơn, tồn tại song song với request chứa thành phần cần sử dụng
            // services
            // Singleton: Vòng đời dài nhất: Tồn tại từ khi có request trỏ tới services cho đến khi
            // app hẹo
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}