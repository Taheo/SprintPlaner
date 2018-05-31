using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SprintPlaner.Models
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role ProjectRole { get; set; }

        public User()
        {
            ID = Guid.NewGuid();
        }

        public enum Role
        {
            ProductOwner,
            Developer,
            ScrumMaster
        }
    }
}