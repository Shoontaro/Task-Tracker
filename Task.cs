using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Tracker
{
    public class Task
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public bool IsItDone { get; set; }

        public void Done()
        {
            this.IsItDone = true;
        }

        public void Update(DateTime date)
        {
            this.UpdateAt = date;
        }

        public Task()
        {
        }

        public Task(int id, string desc, DateTime start, bool done)
        {
            this.Id = id;
            this.Description = desc;
            this.CreatedAt = start;
            this.IsItDone = done;
        }
    }
}
