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
        public void Get_All_Not_Graduated_Students_For_Diploma_One()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var students = StudentRepository.GetAll();
            var studentsNotGraduated = Tracker.GetStudentsNotGraduated(diploma, students);
            Assert.IsTrue(studentsNotGraduated.Any());
        }

        [TestMethod]
        public void Get_All_Not_Graduated_Students_For_Diploma_Two()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var students = StudentRepository.GetAll();
            var studentsNotGraduated = Tracker.GetStudentsNotGraduated(diploma, students);
            Assert.IsTrue(studentsNotGraduated.Any());
        }

        [TestMethod]
        public void Get_All_Not_Graduated_Students_For_Diploma_Three()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var students = StudentRepository.GetAll();
            var studentsNotGraduated = Tracker.GetStudentsNotGraduated(diploma, students);
            Assert.IsTrue(studentsNotGraduated.Any());
        }

        [TestMethod]
        public void Get_All_Graduated_Students_For_Diploma_One()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var students = StudentRepository.GetAll();
            var studentsGraduated = Tracker.GetStudentsGraduated(diploma, students);
            Assert.IsTrue(studentsGraduated.Any());
            Assert.AreEqual(1, studentsGraduated.Count);
        }

        [TestMethod]
        public void Get_All_Graduated_Students_For_Diploma_Two()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var students = StudentRepository.GetAll();
            var studentsGraduated = Tracker.GetStudentsGraduated(diploma, students);
            Assert.IsTrue(studentsGraduated.Any());
            Assert.AreEqual(1, studentsGraduated.Count);
        }

        [TestMethod]
        public void Get_All_Graduated_Students_For_Diploma_Three()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var students = StudentRepository.GetAll();
            var studentsGraduated = Tracker.GetStudentsGraduated(diploma, students);
            Assert.IsTrue(studentsGraduated.Any());
            Assert.AreEqual(1, studentsGraduated.Count);
        }

        #region Test for Diploma One
        [TestMethod]
        public void Student_Has_Graduated_For_Diploma_One_All_Course_Mark_Satisfactory()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var student = StudentRepository.GetByID(1);
            Assert.IsTrue(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_One__Math_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var student = StudentRepository.GetByID(2);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_One__Science_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var student = StudentRepository.GetByID(3);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_One__Literature_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var student = StudentRepository.GetByID(4);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_One__PhysichalEducation_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var student = StudentRepository.GetByID(5);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }
        #endregion

        #region Test for Diploma Two
        [TestMethod]
        public void Student_Has_Graduated_For_Diploma_Two_All_Course_Mark_Satisfactory()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var student = StudentRepository.GetByID(6);
            Assert.IsTrue(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Two__Math_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var student = StudentRepository.GetByID(7);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Two__Science_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var student = StudentRepository.GetByID(8);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Two__Literature_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var student = StudentRepository.GetByID(9);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Two__PhysichalEducation_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(2);
            var student = StudentRepository.GetByID(10);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }
        #endregion

        #region Test for Diploma Three
        [TestMethod]
        public void Student_Has_Graduated_For_Diploma_Three_All_Course_Mark_Satisfactory()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var student = StudentRepository.GetByID(11);
            Assert.IsTrue(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Three__Math_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var student = StudentRepository.GetByID(12);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Three__Science_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var student = StudentRepository.GetByID(13);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Three__Literature_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var student = StudentRepository.GetByID(14);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }

        [TestMethod]
        public void Student_Has_Not_Graduated_For_Diploma_Three__PhysichalEducation_Unsatisfactory()
        {
            var diploma = DiplomaRepository.GetByID(3);
            var student = StudentRepository.GetByID(15);
            Assert.IsFalse(Tracker.StudentHasGraduated(diploma, student));
        }
        #endregion
    }
}


