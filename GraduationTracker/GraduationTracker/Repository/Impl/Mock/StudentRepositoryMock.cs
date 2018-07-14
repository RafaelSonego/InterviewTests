using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrerCruising.GraduationTracker.Repository.Model;

namespace CarrerCruising.GraduationTracker.Repository.Impl.Mock
{
    public class StudentRepositoryMock : IRepository<Student>
    {
        public Student GetByID(int Id)
        {
            var student = GetAll().Single(a => a.Id == Id);
            return student;
        }

        public List<Student> GetAll()
        {
            Student studentA = new Student
            {
                Id = 1,
                Courses = new Course[]
                {
                        new Course{Id = 1, Name = "Math", Mark=95 },
                        new Course{Id = 2, Name = "Science", Mark=95 },
                        new Course{Id = 3, Name = "Literature", Mark=95 },
                        new Course{Id = 4, Name = "Physichal Education", Mark=95 }
                }
            };
            Student studentB = new Student
            {
                Id = 2,
                Courses = new Course[]
                {
                        new Course{Id = 1, Name = "Math", Mark=80 },
                        new Course{Id = 2, Name = "Science", Mark=80 },
                        new Course{Id = 3, Name = "Literature", Mark=80 },
                        new Course{Id = 4, Name = "Physichal Education", Mark=80 }
                }
            };
            Student studentC = new Student
            {
                Id = 3,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark=50 },
                    new Course{Id = 2, Name = "Science", Mark=50 },
                    new Course{Id = 3, Name = "Literature", Mark=50 },
                    new Course{Id = 4, Name = "Physichal Education", Mark=50 }
                }
            };
            Student studentD = new Student
            {
                Id = 4,
                Courses = new Course[]
                {
                    new Course{Id = 1, Name = "Math", Mark=40 },
                    new Course{Id = 2, Name = "Science", Mark=40 },
                    new Course{Id = 3, Name = "Literature", Mark=40 },
                    new Course{Id = 4, Name = "Physichal Education", Mark=40 }
                }
            };

            List<Student> listAllStudents = new List<Student>
            {
                studentA,
                studentB,
                studentC,
                studentD
            };

            return listAllStudents;
        }
    }
}
