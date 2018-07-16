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
#region Students for DIPLOMA Id = 1
                new Student(1)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 60),
                        new StudentProgress(ScienceCourse, 60),
                        new StudentProgress(LiteratureCourse, 80),
                        new StudentProgress(PhysichalEducationCourse, 50)
                    }
                },

                new Student(2)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 49),
                        new StudentProgress(ScienceCourse, 60),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 50)
                    }
                },

                new Student(3)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 50),
                        new StudentProgress(ScienceCourse, 59),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 50)
                    }
                },

                new Student(4)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 50),
                        new StudentProgress(ScienceCourse, 60),
                        new StudentProgress(LiteratureCourse, 69),
                        new StudentProgress(PhysichalEducationCourse, 50)
                    }
                },

                new Student(5)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 50),
                        new StudentProgress(ScienceCourse, 60),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 49)
                    }
                },
#endregion

#region Students for DIPLOMA Id = 2
                new Student(6)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 70),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 60)
                    }
                },

                new Student(7)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 69),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 60)
                    }
                },

                new Student(8)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 70),
                        new StudentProgress(ScienceCourse, 49),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 60)
                    }
                },

                new Student(9)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 70),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 69),
                        new StudentProgress(PhysichalEducationCourse, 60)
                    }
                },

                new Student(10)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 70),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 70),
                        new StudentProgress(PhysichalEducationCourse, 59)
                    }
                },
#endregion

#region Students for DIPLOMA Id = 3
                new Student(11)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 61),
                        new StudentProgress(ScienceCourse, 51),
                        new StudentProgress(LiteratureCourse, 61),
                        new StudentProgress(PhysichalEducationCourse, 71)
                    }
                },

                new Student(12)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 50),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 60),
                        new StudentProgress(PhysichalEducationCourse, 70)
                    }
                },

                new Student(13)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 60),
                        new StudentProgress(ScienceCourse, 40),
                        new StudentProgress(LiteratureCourse, 60),
                        new StudentProgress(PhysichalEducationCourse, 70)
                    }
                },

                new Student(14)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 60),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 50),
                        new StudentProgress(PhysichalEducationCourse, 70)
                    }
                },

                new Student(15)
                {
                    StudentProgress = new List<StudentProgress>()
                    {
                        new StudentProgress(MathCourse, 60),
                        new StudentProgress(ScienceCourse, 50),
                        new StudentProgress(LiteratureCourse, 50),
                        new StudentProgress(PhysichalEducationCourse, 60)
                    }
                }
#endregion

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
