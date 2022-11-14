namespace FileManagerCommands.Commands;

internal class CommandFileInfo : ICommand
{
    public string CommandInfo()
    {
        return "ДОБАВИТЕ ОПИСАНИЕ!";
    }

    private Dictionary<string, string> _commands = new Dictionary<string, string>()
    {
        { "FileInfo",   "FileInfo" },
        { "FI",         "FileInfo" },
        { "fi",         "FileInfo" },
        { "fileinfo",   "FileInfo" }
    };

    public Dictionary<string, string> CommandName()
    {
        return _commands;
    }

    public string Execute(string[] args)
    {
        FileInfo fileInfo = new FileInfo(args[1]);
        string str = $"Информация о файле:\nИмя: {fileInfo.Name} " +
            $"| Расширение: {fileInfo.Extension} " +
            $"| Размер файла: {fileInfo.Length} байт " +
            $"| " +
            $"Создан: {fileInfo.CreationTime} " +
            $"| \nИзменен: {fileInfo.LastWriteTime} " +
            $"| Атрибуты: {fileInfo.Attributes}" +
            $"\nПолный путь: {fileInfo.FullName}";
        return str;
    }
}
