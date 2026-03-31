using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task_Tracker
{
    public class TodoTask
    {
       public enum stat
        {
            todo,
            in_progress,
            done
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsItDone = false;
        public string Status { get; set; }
        //private string _command { get; set; }

        public TodoTask()
        {
        
        }

        public TodoTask(string desc, DateTime start, bool done)
        {
            this.Description = desc;
            this.CreatedAt = start;
            this.Status = stat.todo.ToString();

            this.Id = jsFile.GetLastId();
        }
        
        public TodoTask(string desc, DateTime start, stat val)
        {

            this.Id = jsFile.GetLastId();
            this.Description = desc;
            this.CreatedAt = start;
            this.Status = val.ToString();
            if (val == stat.done)
            {
            this.IsItDone = true;
            }
        }
        
        public TodoTask(string desc, DateTime start, string stat)
        {

            this.Id = jsFile.GetLastId();
            this.Description = desc;
            this.CreatedAt = start;
            this.Status = stat;
           
        }

        //public TodoTask(int id, string desc, DateTime start, bool done)
        //{
        //    this.Id = id;
        //    this.Description = desc;
        //    this.CreatedAt = start;
        //    this.IsItDone = done;
        //}

        public void Print()
        {
            Console.Write($"Задача: {this.Id} {this.Description} Создано в: {this.CreatedAt} статус: {this.Status}");
        }

        public async Task AddAsync()
        {
            this.Id = jsFile.GetLastId();

            string json = JsonSerializer.Serialize(this);

            using (FileStream fs = new FileStream("C:\\Users\\Yumo\\source\\repos\\Task Tracker\\todo.json", FileMode.OpenOrCreate))
            {
                await JsonSerializer.SerializeAsync<TodoTask>(fs, this);
                Console.WriteLine("Data has been saved to file");
            }

            //string json = JsonSerializer.Serialize(this);

            //Console.WriteLine(json);

            //File.WriteAllText("todo.json", json);
            this.Print();
            Console.WriteLine("добавлена");
        }
    }
}
