namespace RestaurantConsoleApp.Commands.Interfaces
{
    public interface ICommand
    {
        string Execute(string[] inputArgs);
    }
}
