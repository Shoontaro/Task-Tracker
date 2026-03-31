using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_Tracker.TodoTask;

namespace Task_Tracker
{
    internal class Command
    {
       

        string command { get; set; }
        string commandText { get; set; }

        public Command(string command)
        {
            string[] words = command.ToLower().Split(' ');
            this.command = words[0];
            this.commandText = string.Join(" ", words.Skip(1));
        }

        public void CreateCommand()
        {
            try
            {
                switch (this.command)
                {
                    case "add":
                        this.Add();
                        break;
                    case "help":
                        this.Help();
                        break;
                    case "list":
                        this.List();
                        break;
                    case "update":
                        this.Update();
                        break;
                    case "delete":
                        this.Delete();
                        break;
                    case "mark-in-progress":
                        this.InProgress();
                        break;
                    case "mark-done":
                        this.Done();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        private void Help()
        {
            Console.WriteLine("\n\n//////////////////////////////////////////////\n\n");
            Console.WriteLine("Use these commands:" +
                "\n add              || for add task (add description)" +
                "\n list             || for display all tasks (list done/todo/in-progress)" +
                "\n mark-in-progress || for mark a task as in progress (mark-in-progress id)" +
                "\n mark-done        || for mark a task as done (mark-done id)" +
                "\n update           || for update task (update id new-description)" +
                "\n delete           || for delete task (delete id)" +
                "\n help             || for help with any command (help command-name)");
            Console.WriteLine("\n\n//////////////////////////////////////////////\n\n");
        }

        public void Done()
        {
            //this.IsItDone = true;
        }

        public void Update(DateTime date)
        {
            //this.UpdateAt = date;
        }

        public void Update()
        {
            //this.UpdateAt = DateTime.Now;
        }

        public void Add()
        {
            TodoTask task = new TodoTask(commandText, DateTime.Now, stat.todo.ToString());
            task.AddAsync();
        }

        public void InProgress() { }

        public void Delete() { }

        public void List() { }

    }
}
