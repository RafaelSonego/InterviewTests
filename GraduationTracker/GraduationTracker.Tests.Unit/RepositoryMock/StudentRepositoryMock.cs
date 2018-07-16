using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrerCruising.GraduationTracker.Repository.Model;
using CarrerCruising.GraduationTracker.Repository.Impl;
using Moq;
using CarrerCruising.GraduationTracker.Repository;
using GraduationTracker.Repository.Impl.Mock;

namespace GraduationTracker.Tests.Unit.Mock
{
    public class StudentRepositoryMock
    {
        public static StudentRepository GetStudentRepository()
        {
            Mock<StudentRepository> StudentRepositoryMock = new Mock<StudentRepository>();

            StudentRepositoryMock
                .Setup(repository => repository.GetAll())
                .Returns(GetAll());

            StudentRepositoryMock
                .Setup(repository => repository.GetByID(It.IsAny<int>()))
                .Returns((int Id) => GetByID(Id));

            return StudentRepositoryMock.Object;
        }

        private static List<Student> GetAll()
        {
            CourseRepository CourseRepository = CourseRepositoryMock.GetCourseRepository();
            Course MathCourse = CourseRepository.GetByID(1);
            Course ScienceCourse = CourseRepository.GetByID(2);
            Course LiteratureCourse = CourseRepository.GetByID(3);
            Course PhysichalEducationCourse = CourseRepository.GetByID(4);

            var AllStudents = new List<Student>()
            {
                new Student(1)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 95),
                        new StudentProgress(ScienceCourse, 95),
                        new StudentProgress(LiteratureCourse, 95),
                        new StudentProgress(PhysichalEducationCourse, 95)
                    }
                },
                new Student(1)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 80),
                        new StudentProgress(ScienceCourse, 80),
                        new StudentProgress(LiteratureCourse, 80),
                        new StudentProgress(PhysichalEducationCourse, 80)
                    }
                },
                new Student(1)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 50),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 50),
                        new StudentProgress(PhysichalEducationCourse, 50)
                    }
                },
                new Student(1)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 40),
                        new StudentProgress(ScienceCourse, 40),
                        new StudentProgress(LiteratureCourse, 40),
                        new StudentProgress(PhysichalEducationCourse, 40)
                    }
                },
            };
            return AllStudents;
        }

        private static Student GetByID(int Id)
        {
            var student = GetAll().Where(a => a.Id == Id).FirstOrDefault();
            return student;
        }
    }
}
