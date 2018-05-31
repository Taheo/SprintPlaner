using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SprintPlaner.Models;

namespace SprintPlaner.BLL
{
    public class MemorySprintService : ISprintService
    {
        private static readonly List<Sprint> Sprints = new List<Sprint>();
        public void Create(Sprint sprint)
        {
            Sprints.Add(sprint);
        }

        public void Delete(Guid id)
        {
            var sprintToDelete = Sprints.SingleOrDefault(s => s.ID == id);
            Sprints.Remove(sprintToDelete);
        }

        public IEnumerable<Sprint> GetAll()
        {
            return Sprints;
        }

        public Sprint GetSprintByID(Guid id)
        {
            var sprintToFind = Sprints.SingleOrDefault(s => s.ID == id);
            return sprintToFind;
        }
    }
}