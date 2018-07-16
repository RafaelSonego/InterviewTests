using CarrerCruising.GraduationTracker.Repository;
using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Model;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraduationTracker.Repository.Impl.Mock
{
    public class CourseRepositoryMock
    {
        public static CourseRepository GetCourseRepository()
        {
            Mock<CourseRepository> CourseRepositoryMock = new Mock<CourseRepository>();
            CourseRepositoryMock
               .Setup(repository => repository.GetAll())
               .Returns(GetAll());

            CourseRepositoryMock
                .Setup(repository => repository.GetByID(It.IsAny<int>()))
                .Returns((int Id) => GetByID(Id));

            return CourseRepositoryMock.Object;
        }

        private static List<Course> GetAll()
        {
            var AllCourses = new List<Course>()
            {
                new Course(1) { Name = "Math"},
                new Course(2) { Name = "Science"},
                new Course(3) { Name = "Literature"},
                new Course(4) { Name = "Physichal Education"}
            };

            return AllCourses;
        }

        public static Course GetByID(int Id)
        {
            var course = GetAll().Where(a => a.Id == Id).FirstOrDefault();
            return course;
        }
    }
}
