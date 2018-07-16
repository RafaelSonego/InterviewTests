using System.Collections.Generic;

namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Requirement : EntityBase
    {
        public Requirement(int Id) : base(Id)
        {
        }

        public int MinimumMark { get; set; }
        public int Credits { get; set; }
        public Course Course { get; set; }

    }
}
