using System.Collections.Generic;

namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Student : EntityBase
    {
        public Student(int Id) : base(Id)
        {
        }

        public List<StudentProgress> StudentProgress { get; set; }

    }
}
