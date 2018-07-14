using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;

namespace CarrerCruising.GraduationTracker.Repository.Impl
{
    public class StudentRepository : IRepository<Student>
    {
        public virtual List<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Student GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
