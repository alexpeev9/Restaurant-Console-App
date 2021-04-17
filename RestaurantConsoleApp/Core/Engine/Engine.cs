namespace RestaurantConsoleApp.Core.Engine
{
    using RestaurantConsoleApp.Core.Engine.Interfaces;
    using System;
    public class Engine : IEngine
    {
        private readonly IServiceProvider _serviceProvider;
        public Engine(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public void Run()
        {
            while (true)
            {
                try
                {
                    var inputArgs = Console.ReadLine()
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    //var commandInterpreter = _serviceProvider.GetService<ICommandInterpreter>();
                    //var result = commandInterpreter.Read(inputArgs);

                    //Console.WriteLine(result);
                }
                catch (ArgumentNullException ane)
                {
                    Console.WriteLine(ane.Message);
                }
                catch (ArgumentException ax)
                {
                    Console.WriteLine(ax.Message);
                }
                catch (InvalidOperationException iox)
                {
                    Console.WriteLine(iox.Message);
                }
            }
        }
    }
}

