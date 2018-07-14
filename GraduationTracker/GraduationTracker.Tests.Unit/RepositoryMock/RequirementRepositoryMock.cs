
using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Model;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit.Mock
{
    class RequirementRepositoryMock
    {

        public static RequirementRepository GetDiplomaRepository()
        {
            Mock<RequirementRepository> RequirementRepositoryMock = new Mock<RequirementRepository>();
            RequirementRepositoryMock
               .Setup(repository => repository.GetAll())
               .Returns(GetAll());

            RequirementRepositoryMock
                .Setup(repository => repository.GetByID(It.IsAny<int>()))
                .Returns((int Id) => GetByID(Id));

            return RequirementRepositoryMock.Object;
        }

        public static List<Requirement> GetAll()
        {
            Requirement MathRequirement = new Requirement { Id = 100, Name = "Math", MinimumMark = 50, Courses = new int[] { 1 }, Credits = 1 };
            Requirement ScienceRequirement = new Requirement { Id = 102, Name = "Science", MinimumMark = 50, Courses = new int[] { 2 }, Credits = 1 };
            Requirement LiteratureRequirement = new Requirement { Id = 103, Name = "Literature", MinimumMark = 50, Courses = new int[] { 3 }, Credits = 1 };
            Requirement PhysichalEducationRequirement = new Requirement { Id = 104, Name = "Physichal Education", MinimumMark = 50, Courses = new int[] { 4 }, Credits = 1 };

            var listAllRequirements = new List<Requirement>
            {
                MathRequirement,
                ScienceRequirement,
                LiteratureRequirement,
                PhysichalEducationRequirement
            };

            return listAllRequirements;
        }

        public static Requirement GetByID(int Id)
        {
            var requirement = GetAll().Single(a => a.Id == Id);
            return requirement;
        }

    }
}
