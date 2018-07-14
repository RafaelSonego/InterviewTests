using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerTests
    {
        [TestMethod]
        public void TestHasCredits()
        {
            var tracker = new GraduationTracker();

            var diploma = Repository.GetDiploma(1); //Get a specific diploma

            var students = Repository.GetStudents(); //Get All Students
            
            var graduated = new List<Tuple<bool, STANDING>>(); 

            //For each student, check if the student has the rules to be graduated and add to the list
            foreach(var student in students)
            {
                graduated.Add(tracker.HasGraduated(diploma, student));      
            }

            //Check if the list is empty - When we don~t have any graduated student
            Assert.IsFalse(graduated.Any());

        }
    }
}
