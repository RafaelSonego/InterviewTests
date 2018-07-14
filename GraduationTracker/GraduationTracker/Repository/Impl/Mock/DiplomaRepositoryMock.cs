using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrerCruising.GraduationTracker.Repository.Model;

namespace CarrerCruising.GraduationTracker.Repository.Impl.Mock
{
    public class DiplomaRepositoryMock : IRepository<Diploma>
    {
        public List<Diploma> GetAll()
        {
            var diploma = new Diploma
            {
                Id = 1,
                Credits = 4,
                Requirements = new int[] { 100, 102, 103, 104 }
            };

            var listAllDiplomas = new List<Diploma>
            {
                diploma
            };

            return listAllDiplomas;
        }

        public Diploma GetByID(int Id)
        {
            var diploma = GetAll().Single(a => a.Id == Id);
            return diploma;
        }
    }
}
