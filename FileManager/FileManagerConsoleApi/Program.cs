using FileManagerCommands;

class Program
{
    static void Main()
    {
        Manager manager = new Manager();

        //while(true)
        {


            string command = Console.ReadLine();
            ConsoleCommandExecute(command);
            Console.WriteLine(manager.ExecuteCommand(command)); 

        }
    }

    static void ConsoleCommandExecute(string commandName)
    {
        switch (commandName)
        {
            case "exit":
                // логика
                break;
            case "clear":
                Console.Clear();
                break;
        }        
    }
}