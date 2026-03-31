using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_Tracker
{
    internal class TaskValidator 
    {
        private List<string> validCommand = new List<string> { "add", "list", "update", "delete", "help", "mark-in-progress", "mark-done" };
        private List<string> idCommand = new List<string> { "update", "delete", "mark-in-progress", "mark-done" };

        public string commandVal { get; set; }
        private bool isItValid = false;

        public TaskValidator()
        {
        }

       public TaskValidator(string command)
        {
            string[] words = command.ToLower().Split(' ');

            if (this.validCommand.Any(v => v == words[0]))
            {
                this.isItValid = true;

                commandVal = words[0];

                if (this.idCommand.Any(v => v == words[0]) && !int.TryParse(words[1], out int num))
                {
                  this.isItValid = false;
                }
            }
        }

        public bool IsValidCommand() { return this.isItValid; }
    }
}
