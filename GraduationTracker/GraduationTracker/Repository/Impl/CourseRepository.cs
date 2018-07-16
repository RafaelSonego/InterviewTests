using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;

namespace CarrerCruising.GraduationTracker.Repository.Impl
{
    public class CourseRepository : IRepository<Course>
    {
        public virtual List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual Course GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
