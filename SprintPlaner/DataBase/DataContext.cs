using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SprintPlaner.DataBase
{
    public class DataContext: DbContext
    {
        public DataContext(): base("ConnStr")
        {

        }

        public DbSet<Models.User> ListOfUsers { get; set; }
        public DbSet<Models.Sprint> ListOfSprints { get; set; }
        public DbSet<Models.Quest> ListOfQuests { get; set; }
    }
}