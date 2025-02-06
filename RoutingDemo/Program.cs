namespace RoutingDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                pattern: "{controller=Home}/{action=Index}"
                );
            app.MapControllerRoute(
                name: "moviesDefault",
                pattern: "{controller=Movies}/{action=Index}"
                );
            app.MapControllerRoute(
                name: "MoviesReleaseByDate",
                pattern: "{controller=Movies}/{action=ByReleasedDate}/{year}/{month}",
                constraints: new { year = @"\d{4}", month = @"\d{2}" }
                );

            app.Run();
        }
    }
}
