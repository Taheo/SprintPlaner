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
        Quest GetQuestByID(Guid id);
        void Create(Quest quest);
        void Delete(Guid id);
        void Edit(Guid id, Quest quest);

        //void Create(Guid sprintId, Quest newpQuest);
        //void Update(Guid sprintId, Guid questid, Quest updatedQuest);
        //void Delete(Guid sprintId, Guid QuestId);
        //Quest Get(Guid questId);
        //IEnumerable<Quest> GetAllBySprint(Guid sprintId);
    }
}
