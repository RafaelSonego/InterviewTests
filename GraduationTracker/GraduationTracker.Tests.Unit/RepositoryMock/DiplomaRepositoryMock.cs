using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrerCruising.GraduationTracker.Repository.Model;
using GraduationTracker.Tests.Unit.Mock;
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
            RequirementRepository RequirementRepository = RequirementRepositoryMock.GetRequirementRepository();
            var ListRequirements = new List<Requirement>()
            {
                RequirementRepository.GetByID(100),
                RequirementRepository.GetByID(102),
                RequirementRepository.GetByID(103),
                RequirementRepository.GetByID(104)

            };
            var diploma = new Diploma(1)
            {
                Credits = 4,
                Requirements = ListRequirements
            };

            var listAllDiplomas = new List<Diploma>
            {
                diploma
            };

            return listAllDiplomas;
        }

        public static Diploma GetByID(int Id)
        {
            var diploma = GetAll().Where(a => a.Id == Id).FirstOrDefault();
            return diploma;
        }
    }
}
