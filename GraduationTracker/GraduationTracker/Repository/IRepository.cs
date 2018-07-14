using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.Repository
{
    interface IRepository<T> where T : EntityBase
    {
        T GetByID(int Id);

        List<T> GetAll();
    }
}
