namespace RestaurantConsoleApp.Core.Engine
{
    using Microsoft.Extensions.DependencyInjection;
    using System;
    using RestaurantConsoleApp.Core.Engine.Interfaces;
    using RestaurantConsoleApp.Commands.CommandInterpreter;

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
                          .Split(" ", StringSplitOptions.RemoveEmptyEntries); // takes our input and splits it into array

                    var commandInterpreter = _serviceProvider.GetService<ICommandInterpreter>();
                    var result = commandInterpreter.Read(inputArgs); // pass our array to Command Interpreter

                    Console.WriteLine(result); // print result
                }
                catch (ArgumentNullException ane) // when a null reference is passed to a method that does not accept it as a valid argument.
                {
                    Console.WriteLine(ane.Message);
                }
                catch (ArgumentException ax) // when one of the arguments provided to a method is not valid.
                {
                    Console.WriteLine(ax.Message);
                }
                catch (InvalidOperationException iox)
                {
                    Console.WriteLine(iox.Message); // when a method call is invalid for the object's current state.
                }
            }
        }
    }
}

