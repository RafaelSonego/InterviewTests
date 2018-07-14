using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Impl.Mock;
using CarrerCruising.GraduationTracker.Repository.Model;
using GraduationTracker.Tests.Unit.Mock;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Tests.Unit
{
    [TestClass]
    public class GraduationTrackerBase
    {
        public StudentRepository StudentRepository { get; private set; }
        public DiplomaRepository DiplomaRepository { get; private set; }
        public GraduationTracker Tracker { get; private set; }

        [TestInitialize]
        public void BeforeTest()
        {
            StudentRepository = StudentRepositoryMock.GetStudentRepository();
            DiplomaRepository = DiplomaRepositoryMock.GetDiplomaRepository();
            Tracker = new GraduationTracker();
        }

    }
}
