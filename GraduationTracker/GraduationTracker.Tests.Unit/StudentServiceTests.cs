using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CarrerCruising.GraduationTracker;
using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Impl.Mock;
using CarrerCruising.GraduationTracker.Repository.Model;
using CarrerCruising.GraduationTracker.Service;
using CarrerCruising.GraduationTracker.AcademicStanding;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class StudentServiceTests
    {
        #region Standing SumaCumLaude
        [TestMethod]
        public void Check_Standing_Is_SumaCumLaude()
        {
            int studentAverage = 100;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreEqual(Standing.SumaCumLaude, standing);
        }

        [TestMethod]
        public void Check_Standing_Is_Not_SumaCumLaude()
        {
            int studentAverage = 94;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreNotEqual(Standing.SumaCumLaude, standing);
        }
        #endregion

        #region Standing _MagnaCumLaude
        [TestMethod]
        public void Check_Standing_Is_MagnaCumLaude()
        {
            int studentAverage = 94;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreEqual(Standing.MagnaCumLaude, standing);
        }

        [TestMethod]
        public void Check_Standing_Is_MagnaCumLaude_Range_80()
        {
            int studentAverage = 80;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreEqual(Standing.MagnaCumLaude, standing);
        }

        [TestMethod]
        public void Check_Standing_Is_Not_MagnaCumLaude()
        {
            int studentAverage = 79;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreNotEqual(Standing.MagnaCumLaude, standing);
        }
        #endregion

        #region Standing Average

        [TestMethod]
        public void Check_Standing_Is_Average()
        {
            int studentAverage = 50;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreEqual(Standing.Average, standing);
        }

        [TestMethod]
        public void Check_Standing_Is_Not_Average()
        {
            int studentAverage = 49;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreNotEqual(Standing.Average, standing);
        }
        #endregion

        #region Standing Remedial

        [TestMethod]
        public void Check_Standing_Is_Remedial_Without_Average()
        {
            int studentAverage = 49;
            int studentCredits = 100;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreEqual(Standing.Remedial, standing);
        }

        [TestMethod]
        public void Check_Standing_Is_Remedial_Student_Credit_Lees_Then_Diploma_Credit()
        {
            int studentAverage = 50;
            int studentCredits = 90;
            int diplomaCredit = 100;
            var standing = StudentService.GetAcademicStanding(studentAverage, studentCredits, diplomaCredit);
            Assert.AreEqual(Standing.Remedial, standing);
        }
        #endregion

        [TestMethod]
        public void Check_IsGraduated_Standing_SumaCumLaude()
        {
            Assert.IsTrue(StudentService.IsGraduated(Standing.SumaCumLaude));
        }

        [TestMethod]
        public void Check_IsGraduated_Standing_Average()
        {
            Assert.IsTrue(StudentService.IsGraduated(Standing.Average));
        }

        [TestMethod]
        public void Check_IsGraduated_Standing_MagnaCumLaude()
        {
            Assert.IsTrue(StudentService.IsGraduated(Standing.MagnaCumLaude));
        }

        [TestMethod]
        public void Check_IsGraduated_Standing_None()
        {
            Assert.IsFalse(StudentService.IsGraduated(Standing.None));
        }

        [TestMethod]
        public void Check_IsGraduated_Standing_Remedial()
        {
            Assert.IsFalse(StudentService.IsGraduated(Standing.Remedial));
        }

    }
}
