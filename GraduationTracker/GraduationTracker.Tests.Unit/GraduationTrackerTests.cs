using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CarrerCruising.GraduationTracker;
using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Impl.Mock;
using CarrerCruising.GraduationTracker.Repository.Model;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests : GraduationTrackerBase
    {
        [TestMethod]
        public void Do_Not_Have_Students_Graduated_Of_All_List_Of_Student()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var student = StudentRepository.GetByID(1);
            var graduated = new List<Student>();

            Assert.IsTrue(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Get_All_Graduated_Students()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var students = StudentRepository.GetAll();

            var studentsGraduated = Tracker.GetStudentsGraduated(diploma, students);

            Assert.IsTrue(studentsGraduated.Any());
            Assert.AreEqual(3, studentsGraduated.Count);
        }

        [TestMethod]
        public void Get_All_Not_Graduated_Students()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var students = StudentRepository.GetAll();

            var studentsNotGraduated = Tracker.GetStudentsNotGraduated(diploma, students);

            Assert.IsTrue(studentsNotGraduated.Any());
            Assert.AreEqual(1, studentsNotGraduated.Count);
        }

    }
}
