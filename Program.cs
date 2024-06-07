
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.EntityFrameworkCore;
namespace ApiWinterWhispers
{
    public class Program
    {
        public static void Main(string[] args)
        {
                     
                        
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("MyConnection");
            Console.WriteLine("Connectionstr�ngen: " + connectionString);
            builder.Services.AddDbContext<DAL.MyDBContext>(options => options.UseSqlServer(connectionString));
            builder.Services.AddTransient<DAL.TopicManager>();


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
