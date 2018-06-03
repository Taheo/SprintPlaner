using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintPlaner.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int StoryValue { get; set; }

        public Task()
        {
            Id = Guid.NewGuid();
        }
    }
}