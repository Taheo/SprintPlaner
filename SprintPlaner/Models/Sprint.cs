using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintPlaner.Models
{
    public class Sprint
    {
        public List<Task> TaskList { get; set; }
        public DateTime Deadline { get; set; }

    }
}