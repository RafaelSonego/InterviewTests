﻿namespace CarrerCruising.GraduationTracker.Repository.Model
{
    public class Course : EntityBase
    {
        public Course(int Id) : base(Id)
        {
        }

        public string Name { get; set; }
    }
}
