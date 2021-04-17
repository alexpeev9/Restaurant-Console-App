namespace RestaurantConsoleApp.Commands
{
    using RestaurantConsoleApp.Commands.Interfaces;
    using System;
    using System.Threading;

    public class ExitCommand : ICommand
    {
        public string Execute(string[] inputArgs)
        {
            for (int i = 5; i >= 1; i--)
            {
                Console.WriteLine($"Exit after {i}s");
                Thread.Sleep(1000);
                Console.Clear();
            }

            Console.WriteLine("The app was successfully stopped");

            Environment.Exit(0);
            return null;
        }
    }
}
