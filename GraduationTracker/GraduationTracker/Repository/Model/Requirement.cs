﻿namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Requirement : EntityBase
    {
        public Requirement(int Id) : base(Id)
        {
        }

        public string Name { get; set; }
        public int MinimumMark { get; set; }
        public int Credits { get; set; }
        public int[] Courses { get; set; }

    }
}
