using Task_Tracker;

internal class Program
{
    private static void Greeting()
    {
        Console.WriteLine("Hello, User! Nice to meet you");
        Console.WriteLine("\n\n//////////////////////////////////////////////\n\n");
        Console.WriteLine("Use these commands:" +
            "\n add              || for add task (add description)" +
            "\n list             || for display all tasks" +
            "\n mark-in-progress || for mark a task as in progress (mark-in-progress id)" +
            "\n mark-done        || for mark a task as done (mark-done id)" +
            "\n update           || for update task (update id new-description)" +
            "\n delete           || for delete task (delete id)" +
            "\n help             || for help with any command (help command-name)");
        Console.WriteLine("\n\n//////////////////////////////////////////////\n\n");
    }

    private static void TakeCommand()
    {
        string command;
        command = Console.ReadLine().Trim();
        if (new TaskValidator(command).IsValidCommand() == true) { 
        
        }

       
    }

    private static void Main(string[] args)
    {
        Greeting();

        while (true)
        {
            TakeCommand();
        }
    }
}