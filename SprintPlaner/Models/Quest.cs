using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintPlaner.Models
{
    public class Quest
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public int StoryValue { get; set; }
        public bool StatusInSprint { get; set; }

        public Quest()
        {
            StatusInSprint = false;
            Id = Guid.NewGuid();
        }
    }
}