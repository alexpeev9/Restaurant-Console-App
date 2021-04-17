namespace RestaurantConsoleApp.Repositories.Interfaces
{
    using System.Collections.Generic;
    public interface IRepository<T>
    {
        ICollection<T> Repository { get; }
        void Add(T client);
        bool Remove(T client);
        T Get(string client);
    }
}
