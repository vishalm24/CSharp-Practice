namespace Vidly
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

            //Not working may be error due to latest version
            app.MapControllerRoute(
                "MovieByReleaseDate",
                "movie/released/{year}/{month}",
                new { controller = "Movie", action = "ByReleaseDate"},//This is used for mapping given url to controller
                new { year = "2015 | 2016", month = @"\d{2}"});//by applying 2015 and 2016 we are limiting the years which we want
                                                               //and by using \d{2} we are ensuring that month field has 2 digits in it

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
