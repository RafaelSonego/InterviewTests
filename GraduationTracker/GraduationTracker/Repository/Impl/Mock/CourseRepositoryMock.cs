using CarrerCruising.GraduationTracker.Repository;
using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Impl.Mock
{
    class CourseRepositoryMock : IRepository<Course>
    {
        public List<Course> GetAll()
        {
            throw new NotImplementedException();
        }

        public Course GetByID(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
