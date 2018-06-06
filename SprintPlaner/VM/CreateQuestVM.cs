using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SprintPlaner.VM
{
    public class CreateQuestVM
    {
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "To pole jest wymagane.")]
        public int StoryValue { get; set; }
    }
}