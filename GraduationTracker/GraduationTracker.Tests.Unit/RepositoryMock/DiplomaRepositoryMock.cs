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

            var AllDiplomas = new List<Diploma>
            {
                //Total of Requirements Credit = 70
                new Diploma(1)
                {
                    Credits = 61,
                    Requirements = new List<Requirement>()
                    {
                        RequirementRepository.GetByID(100), //MinimumMark = 50
                        RequirementRepository.GetByID(106), //MinimumMark = 60
                        RequirementRepository.GetByID(111), //MinimumMark = 70
                        RequirementRepository.GetByID(104) //MinimumMark = 50

                    }
                },
                //Total of Requirements Credit = 90
                new Diploma(2)
                {
                    Credits = 81,
                    Requirements = new List<Requirement>()
                    {
                        RequirementRepository.GetByID(109), //MinimumMark = 70
                        RequirementRepository.GetByID(102), //MinimumMark = 50
                        RequirementRepository.GetByID(111), //MinimumMark = 70
                        RequirementRepository.GetByID(108) //MinimumMark = 60

                    }
                },
                //Total of Requirements Credit = 80
                new Diploma(3)
                {
                    Credits = 71,
                    Requirements = new List<Requirement>()
                    {
                        RequirementRepository.GetByID(105), //MinimumMark = 60
                        RequirementRepository.GetByID(102), //MinimumMark = 50
                        RequirementRepository.GetByID(107), //MinimumMark = 60
                        RequirementRepository.GetByID(112) //MinimumMark = 70

                    }
                }
            };

            return AllDiplomas;
        }

        public static Diploma GetByID(int Id)
        {
            var diploma = GetAll().Where(a => a.Id == Id).FirstOrDefault();
            return diploma;
        }
    }
}
