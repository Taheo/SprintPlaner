using SprintPlaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintPlaner.BLL
{
    interface ISprintService
    {
        IEnumerable<Sprint> GetAll();
        Sprint GetSprintByID(Guid id);
        void Create(Sprint sprint);
        void Delete(Guid id);
    }
}
