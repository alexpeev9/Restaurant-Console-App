using RestaurantConsoleApp.Core.IO.Interfaces;
using System;

namespace RestaurantConsoleApp.Core.IO
{
    public class ConsoleReader : IReader
    {
        public string ReadLine() => Console.ReadLine();

    }
}
