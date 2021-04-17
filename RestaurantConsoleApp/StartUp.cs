namespace RestaurantConsoleApp
{
    using Microsoft.Extensions.DependencyInjection;
    using RestaurantConsoleApp.Commands.CommandInterpreter;
    using RestaurantConsoleApp.Core.Engine;
    using RestaurantConsoleApp.Core.Engine.Interfaces;
    using RestaurantConsoleApp.Factories;
    using RestaurantConsoleApp.Factories.Interfaces;
    using RestaurantConsoleApp.Models.Interfaces;
    using RestaurantConsoleApp.Models.Products.Interfaces;
    using RestaurantConsoleApp.Repositories;
    using RestaurantConsoleApp.Repositories.Interfaces;
    using System;
    public class StartUp
    {
        static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();
            IEngine engine = serviceProvider.GetService<IEngine>();
            engine.Run();
        }
        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddTransient<IProductFactory, ProductFactory>();
            serviceCollection.AddTransient<IClientFactory, ClientFactory>();
            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();


            serviceCollection.AddTransient<IEngine, Engine>();

            serviceCollection.AddSingleton<IRepository<IBaseModel>, ClientRepository>();
            serviceCollection.AddSingleton<IRepository<IProduct>, ProductRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
