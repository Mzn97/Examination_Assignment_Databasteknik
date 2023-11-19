using Examination_Assignment.Contexts;
using Examination_Assignment.Menus;
using Examination_Assignment.Repositories;
using Examination_Assignment.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Examination_Assignment;

public class Program
{
    static async Task Main(string[] args)
    {
        var services = new ServiceCollection();

        services.AddDbContext<DataContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\education\cms23\databasteknik\Lektion-8\Assignment\Contexts\assignment_database.mdf;Integrated Security=True;Connect Timeout=30"));

        // Repositories 
        services.AddScoped<AddressRepository>();
        services.AddScoped<CustomerRepository>();
        services.AddScoped<PricingUnitRepository>();
        services.AddScoped<ProductCategoryRepository>();
        services.AddScoped<ProductRepository>();

        // Services
        services.AddScoped<CustomerService>();
        services.AddScoped<ProductService>();

        // Menus
        services.AddScoped<CustomerMenu>();
        services.AddScoped<ProductMenu>();
        services.AddScoped<MainMenu>();


        var sp = services.BuildServiceProvider();
        var mainMenu = sp.GetRequiredService<MainMenu>();
        await mainMenu.StartAsync();
    }
}