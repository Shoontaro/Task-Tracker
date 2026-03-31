using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Xml.Linq;

namespace Task_Tracker
{
    class jsFile
    {

        public static int GetLastId()
        {
            GetListToDo();
            //if ()
            //{
                return 0;
            //}
        }

        public static TodoTask GetListToDo()
        {
            TodoTask element = new TodoTask();

            using (FileStream fs = new FileStream("C:\\Users\\Yumo\\source\\repos\\Task Tracker\\todo.json", FileMode.OpenOrCreate))
            {
                 element = JsonSerializer.Deserialize<TodoTask>(fs);
            }
            return element;
        }

        //public static string SaveInFile()
        //{

        //    using (FileStream fs = new FileStream("todo.json", FileMode.OpenOrCreate))
        //    {
        //        Person tom = new Person("Tom", 37);
        //        await JsonSerializer.SerializeAsync<Person>(fs, tom);
        //        Console.WriteLine("Data has been saved to file");
        //    }

        //}

    }
}
