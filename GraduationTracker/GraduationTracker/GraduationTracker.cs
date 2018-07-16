using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Model;
using CarrerCruising.GraduationTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using CarrerCruising.GraduationTracker.Service;
using CarrerCruising.GraduationTracker.AcademicStanding;

namespace GraduationTracker
{
    public partial class GraduationTracker
    {
        public List<Student> GetStudentsGraduated(Diploma diploma, List<Student> listStudents)
        {
            var studentsGraduated = new List<Student>();
            foreach(Student student in listStudents)
            {
                if(StudentHasGraduated(diploma, student))
                    studentsGraduated.Add(student);
            }
            return studentsGraduated;
        }

        public List<Student> GetStudentsNotGraduated(Diploma diploma, List<Student> listStudents)
        {
            var studentsGraduated = new List<Student>();
            foreach (Student student in listStudents)
            {
                if (!StudentHasGraduated(diploma, student))
                    studentsGraduated.Add(student);
            }
            return studentsGraduated;
        }

        public bool StudentHasGraduated(Diploma diploma, Student student)
        {
            var StudentAverage = StudentService.CalculateAverageForDiplomaRequirements(diploma.Requirements, student.StudentProgress);

            var standing = StudentService.GetAcademicStanding(StudentAverage);

            return StudentService.IsGraduated(standing);
        }

    }
}
