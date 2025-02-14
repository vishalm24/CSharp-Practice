
using Microsoft.EntityFrameworkCore;
using Web_API__Employee_Management_.Data;
using Web_API__Employee_Management_.IRepository;
using Web_API__Employee_Management_.Repository;

namespace Web_API__Employee_Management_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ApplicationDbContext>(Option => Option.UseSqlServer
                (builder.Configuration.GetConnectionString
                    ("DefaultConnection")));
            builder.Services.AddScoped<IDeparment, DepartmentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
