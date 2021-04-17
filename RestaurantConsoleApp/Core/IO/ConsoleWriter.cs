namespace RestaurantConsoleApp.Core.IO
{
    using RestaurantConsoleApp.Core.IO.Interfaces;
    using System;
    public class ConsoleWriter : IWriter
    {
        public void WriteLine(string content)
        {
            Console.WriteLine(content);
        }

        public void Write(string content)
        {
            Console.Write(content);
        }
    }
}
