namespace FileManagerCommands;

internal interface ICommand
{
    /// <summary>
    /// Метод выполнить
    /// </summary>
    string Execute(string[] args);
    
    /// <summary>
    /// Возвращает описание команды
    /// </summary>
    /// <returns></returns>
    string CommandInfo();

    /// <summary>
    /// Словарь наименований
    /// </summary>
    /// <returns></returns>
    Dictionary<string, string> CommandName();
}
