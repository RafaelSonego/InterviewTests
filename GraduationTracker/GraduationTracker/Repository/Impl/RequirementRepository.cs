using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;

namespace CarrerCruising.GraduationTracker.Repository.Impl
{
    public class RequirementRepository : IRepository<Requirement>
    {
        public virtual List<Requirement> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Requirement GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
