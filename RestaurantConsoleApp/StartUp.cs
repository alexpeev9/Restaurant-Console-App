namespace RestaurantConsoleApp
{
    using Microsoft.Extensions.DependencyInjection;
    using RestaurantConsoleApp.Core.IO;
    using RestaurantConsoleApp.Core.IO.Interfaces;
    using System;
    public class StartUp
    {
        static void Main()
        {
            IServiceProvider serviceProvider = ConfigureServices();
        }
        private static IServiceProvider ConfigureServices()
        {
            var serviceCollection = new ServiceCollection();

            //serviceCollection.AddTransient<IItemFactory, ItemFactory>();
            //serviceCollection.AddTransient<IMonsterFactory, MonsterFactory>();
            //serviceCollection.AddTransient<IHeroFactory, HeroFactory>();
            //serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();

            serviceCollection.AddTransient<IWriter, ConsoleWriter>();
            serviceCollection.AddTransient<IReader, ConsoleReader>();

            serviceCollection.AddTransient<IEngine, Engine>();

            //serviceCollection.AddSingleton<IRepository<IHero>, HeroRepository>();
            //serviceCollection.AddSingleton<IRepository<IMonster>, MonsterRepository>();
            //serviceCollection.AddSingleton<IRepository<IItem>, ItemRepository>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
