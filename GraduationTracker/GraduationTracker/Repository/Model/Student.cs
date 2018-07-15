namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Student : EntityBase
    {
        public Student(int Id) : base(Id)
        {
        }

        public Course[] Courses { get; set; }

    }
}
