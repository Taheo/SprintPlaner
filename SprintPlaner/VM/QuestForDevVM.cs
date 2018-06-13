using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SprintPlaner.VM
{
    public class QuestForDevVM
    {
        [Required]
        public int StoryValue { get; set; }
        public string Note { get; set; }
    }
}