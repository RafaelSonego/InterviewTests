namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Course : EntityBase
    {
        public string Name { get; set; }
        public int Mark { get; set; }
        public int Credits { get; }

    }
}
