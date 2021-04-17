namespace RestaurantConsoleApp.Commands.CommandInterpreter
{
    public interface ICommandInterpreter
    {
        string Read(string[] args);
    }
}
