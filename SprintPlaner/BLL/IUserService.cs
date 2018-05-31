using SprintPlaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintPlaner.BLL
{
    interface IUserService
    {
        IEnumerable<User> GetAll();
        User GetByID(Guid id);
        void Create(User user);
        void Delete(Guid id);
    }
}
