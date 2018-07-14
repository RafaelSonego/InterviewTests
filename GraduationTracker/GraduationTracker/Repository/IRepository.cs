using CarrerCruising.GraduationTracker.Repository.Model;
using System.Collections.Generic;

namespace CarrerCruising.GraduationTracker.Repository
{
    interface IRepository<T> where T : EntityBase
    {
        T GetByID(int Id);

        List<T> GetAll();
    }
}
