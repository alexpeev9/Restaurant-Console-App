namespace RestaurantConsoleApp.Commands.CommandInterpreter
{
    using RestaurantConsoleApp.Commands.Interfaces;
    using System;
    using System.Linq;
    using System.Reflection;
    public class CommandInterpreter : ICommandInterpreter
    {
        // Suffix and InvalidCommandMessage are with UpperCase because they are constraints
        private const string Suffix = "command";
        private const string InvalidCommandMessage = "Invalid Command!"; // Display message

        private readonly IServiceProvider serviceProvider;
        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }
        public string Read(string[] args)
        {
            var commandName = args[0].ToLower() + Suffix;  // First word is our command and we add suffix to find it from all classes 

            var inputArgs = args
                .Skip(1)
                .ToArray(); // copy of our InputArray without Command (Skip starts from 1)

            var type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName); // Searches command in assembly

            if (type == null)
            {
                throw new ArgumentNullException(InvalidCommandMessage);
            }

            var constructor = type
                .GetConstructors()
                .FirstOrDefault(); // returns constructor defined for the current type.

            var constructorParams = constructor
                ?.GetParameters()
                .Select(x => x.ParameterType)
                .ToArray(); // parameter types for constructor

            var services = constructorParams
                ?.Select(this.serviceProvider.GetService)
                .ToArray(); // obj[] - real loaded in our memory

            var typeInstance = Activator.CreateInstance(type, services) as ICommand; // creates new instance and adds parameters

            string result = typeInstance?.Execute(inputArgs); // result from method we executed

            return result;
        }
    }
}
