
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

            Course MathCourse = CourseRepository.GetByID(1);
            Course ScienceCourse = CourseRepository.GetByID(2);
            Course LiteratureCourse = CourseRepository.GetByID(3);
            Course PhysichalEducationCourse = CourseRepository.GetByID(4);

            var AllRequirements = new List<Requirement>()
            {
                new Requirement(100) { MinimumMark = 50, Course = MathCourse, Credits = 10 },
                new Requirement(105) { MinimumMark = 60, Course = MathCourse, Credits = 20 },
                new Requirement(109) { MinimumMark = 70, Course = MathCourse, Credits = 30 },

                new Requirement(102) { MinimumMark = 50, Course = ScienceCourse, Credits = 10 },
                new Requirement(106) { MinimumMark = 60, Course = ScienceCourse, Credits = 20 },
                new Requirement(110) { MinimumMark = 70, Course = ScienceCourse, Credits = 30 },

                new Requirement(103) { MinimumMark = 50, Course = LiteratureCourse, Credits = 10 },
                new Requirement(107) { MinimumMark = 60, Course = LiteratureCourse, Credits = 20 },
                new Requirement(111) { MinimumMark = 70, Course = LiteratureCourse, Credits = 30 },

                new Requirement(104) { MinimumMark = 50, Course = PhysichalEducationCourse, Credits = 10 },
                new Requirement(108) { MinimumMark = 60, Course = PhysichalEducationCourse, Credits = 20 },
                new Requirement(112) { MinimumMark = 70, Course = PhysichalEducationCourse, Credits = 30 }
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
