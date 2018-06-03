using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintPlaner.BLL
{
    interface ITaskService
    {
        IEnumerable<Task> GetAll();
        Task GetSprintByID(Guid id);
        void Create(Task sprint);
        void Delete(Guid id);
    }
}
