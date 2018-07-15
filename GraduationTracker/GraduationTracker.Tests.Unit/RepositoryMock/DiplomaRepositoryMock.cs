using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrerCruising.GraduationTracker.Repository.Model;
using Moq;

namespace CarrerCruising.GraduationTracker.Repository.Impl.Mock
{
    public class DiplomaRepositoryMock
    {
        public static DiplomaRepository GetDiplomaRepository()
        {
            Mock<DiplomaRepository> DiplomaRepositoryMock = new Mock<DiplomaRepository>();
            DiplomaRepositoryMock
               .Setup(repository => repository.GetAll())
               .Returns(GetAll());

            DiplomaRepositoryMock
                .Setup(repository => repository.GetByID(It.IsAny<int>()))
                .Returns((int Id) => GetByID(Id));

            return DiplomaRepositoryMock.Object;
        }

        private static List<Diploma> GetAll()
        {
            var diploma = new Diploma(1)
            {
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var listAllDiplomas = new List<Diploma>
            {
                diploma
            };

            return listAllDiplomas;
        }

        public static Diploma GetByID(int Id)
        {
            var diploma = GetAll().Single(a => a.Id == Id);
            return diploma;
        }
    }
}
