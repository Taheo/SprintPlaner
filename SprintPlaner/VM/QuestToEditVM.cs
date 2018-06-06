using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SprintPlaner.VM
{
    public class QuestToEditVM
    {
        [ScaffoldColumn(false)]
        [HiddenInput(DisplayValue = false)]
        public Guid ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public int StoryValue { get; set; }
    }
}