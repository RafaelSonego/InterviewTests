using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using CarrerCruising.GraduationTracker;
using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Impl.Mock;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests : GraduationTrackerBase
    {
        [TestMethod]
        public void TestHasCredits()
        {
            var diploma = DiplomaRepository.GetByID(1);
            var students = StudentRepository.GetAll();
            var graduated = new List<Tuple<bool, STANDING>>(); 

            //For each student, check if the student has the rules to be graduated and add to the list
            foreach(var student in students)
            {
                graduated.Add(Tracker.HasGraduated(diploma, student));      
            }

            //Check if the list is empty - When we don~t have any graduated student
            Assert.IsFalse(graduated.Any());

        }
    }
}
