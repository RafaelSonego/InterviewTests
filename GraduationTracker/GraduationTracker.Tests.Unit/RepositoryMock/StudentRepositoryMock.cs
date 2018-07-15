using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrerCruising.GraduationTracker.Repository.Model;
using CarrerCruising.GraduationTracker.Repository.Impl;
using Moq;
using CarrerCruising.GraduationTracker.Repository;

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
            var AllStudents = new List<Student>()
            {
                new Student(1)
            {
                Courses = new Course[]
                {
                        new Course(1){Name = "Math", Mark=95 },
                        new Course(2){Name = "Science", Mark=95 },
                        new Course(3){Name = "Literature", Mark=95 },
                        new Course(4){Name = "Physichal Education", Mark=95 }
                }
            },
                new Student(2)
            {
                Courses = new Course[]
                {
                        new Course(1){Name = "Math", Mark=80 },
                        new Course(2){Name = "Science", Mark=80 },
                        new Course(3){Name = "Literature", Mark=80 },
                        new Course(4){Name = "Physichal Education", Mark=80 }
                }
            },
                new Student(3)
            {
                Courses = new Course[]
                {
                    new Course(1){Name = "Math", Mark=50 },
                    new Course(2){Name = "Science", Mark=50 },
                    new Course(3){Name = "Literature", Mark=50 },
                    new Course(4){Name = "Physichal Education", Mark=50 }
                }
            },
                new Student(4)
            {
                Courses = new Course[]
                {
                    new Course(1){Name = "Math", Mark=40 },
                    new Course(2){Name = "Science", Mark=40 },
                    new Course(3){Name = "Literature", Mark=40 },
                    new Course(4){Name = "Physichal Education", Mark=40 }
                }
            }
        };
            return AllStudents;
        }

        private static Student GetByID(int Id)
        {
            var student = GetAll().Single(a => a.Id == Id);
            return student;
        }
    }
}
