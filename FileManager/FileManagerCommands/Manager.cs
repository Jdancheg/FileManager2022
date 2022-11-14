using FileManagerCommands.Commands;
using System.IO;
using System.Reflection;

namespace FileManagerCommands
{
    public class Manager
    {        
        public Manager()
        {
            SetCommandsList();
        }


        private string[] _args;
        private static List<ICommand> _commands = new List<ICommand>();

        private void SetCommandsList()
        {
            Assembly asm = Assembly.LoadFrom("FileManagerCommands.dll");        // создание сборки из библиотеки классов
            Type[] types = asm.GetTypes();                                  // выгрузка классов в массив
            foreach (Type type in types)                                    // перебираем классы и интерфейсы
            {
                if ((type.IsInterface == false)
                    && (type.IsAbstract == false)
                    && (type.GetInterface("ICommand") != null))               // не добавляем абстрактные классы и интерфейсы
                {
                    ICommand value = (ICommand)Activator.CreateInstance(type);
                    _commands.Add(value);                           // подгружаем этот класс в список уроков                        
                }
            }
        }

        public string ExecuteCommand(string command)
        {            
            ParseCommandString(command);

            string result = "";
            foreach (ICommand com in _commands)
            {
                if (com.CommandName().ContainsKey(_args[0]))
                {                    
                    result = com.Execute(_args);
                }
            }
            if (result == "")
                return "Ошибка!";
            else
                return result;
        }

        /// <summary>
        /// Метод "парсит" строку команды
        /// </summary>
        private void ParseCommandString(string command)
        {
            _args = command.Split(' ');         
        }


        /// <summary>
        /// Возвращает справку по всем командам
        /// </summary>
        /// <returns></returns>
        public string CommandsInfo()
        {
            // логика
            return "Что-то возвращает";
        }
    }
}