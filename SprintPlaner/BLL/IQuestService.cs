using SprintPlaner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprintPlaner.BLL
{
    interface IQuestService
    {
        IEnumerable<Quest> GetAll();
        Quest GetSprintByID(Guid id);
        void Create(Quest quest);
        void Delete(Guid id);
    }
}
