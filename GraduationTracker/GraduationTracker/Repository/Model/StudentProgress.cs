using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class StudentProgress : EntityBase
    {
        public Course Course { get; private set; }
        public int Mark { get; private set; }

        public StudentProgress(int Id) : base(Id)
        {
        }

        public StudentProgress(Course Course, int Mark)
        {
            this.Course = Course;
            this.Mark = Mark;
        }

    }
}
