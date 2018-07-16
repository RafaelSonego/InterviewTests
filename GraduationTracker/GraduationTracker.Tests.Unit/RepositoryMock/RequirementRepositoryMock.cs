
using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Model;
using GraduationTracker.Repository.Impl.Mock;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace GraduationTracker.Tests.Unit.Mock
{
    class RequirementRepositoryMock
    {

        public static RequirementRepository GetRequirementRepository()
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
            CourseRepository CourseRepository = CourseRepositoryMock.GetCourseRepository();
            var AllRequirements = new List<Requirement>()
            {
                new Requirement(100) { MinimumMark = 50, Course = CourseRepository.GetByID(1), Credits = 1 },
                new Requirement(102) { MinimumMark = 50, Course = CourseRepository.GetByID(2), Credits = 1 },
                new Requirement(103) { MinimumMark = 50, Course = CourseRepository.GetByID(3), Credits = 1 },
                new Requirement(104) { MinimumMark = 50, Course = CourseRepository.GetByID(4), Credits = 1 }
            };
            return AllRequirements;
        }

        public static Requirement GetByID(int Id)
        {
            var requirement = GetAll().Where(a => a.Id == Id).FirstOrDefault();
            return requirement;
        }

    }
}
