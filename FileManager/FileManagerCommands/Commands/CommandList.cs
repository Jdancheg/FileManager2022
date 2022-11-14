namespace FileManagerCommands.Commands;

internal class CommandList : ICommand
{
    public string CommandInfo()
    {
        return "ДОБАВИТЕ ОПИСАНИЕ!";
    }

    private Dictionary<string, string> _commands = new Dictionary<string, string>()
    {
        { "List",   "List" },
        { "list",   "List" },
        { "LS",     "List" },
        { "ls",     "List" },
    };

    public Dictionary<string, string> CommandName()
    {
        return _commands;
    }

    public string Execute(string[] args)
    {
        return "";
        // ДОБАВИТЕ ЛОГИКУ   
    }
}
