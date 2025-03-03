using Microsoft.EntityFrameworkCore;
using Report_Pubs.Controllers;
using Report_Pubs.Interface;
using Report_Pubs.Models;
using Report_Pubs.Services;

namespace Report_Pubs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<PubsContext>(option =>
                option.UseSqlServer(builder.Configuration.GetConnectionString("MyyyConnection")));

            builder.Services.AddTransient<ReportController>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IAnalysisRepository, AnalysisRepository>();
            builder.Services.AddScoped<IAuthorsBooksRepository, AuthorsBooksRepository>();
            builder.Services.AddScoped<IBookTypeRepository, BookTypeRepository>();

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
                pattern: "{controller=Report}/{action=DropDownList}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
