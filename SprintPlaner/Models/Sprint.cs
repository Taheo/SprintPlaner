using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintPlaner.Models
{
    public class Sprint
    {
        public Guid ID { get; set; }
        public List<Task> TaskList { get; set; }
        public DateTime Deadline { get; set; }

        public Sprint()
        {
            ID = Guid.NewGuid();
        }
    }
}