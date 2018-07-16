using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.AcademicStanding
{
    public interface IStanding
    {
        Standing GetStanding(int Average);

        void SetNextStandingVerification(IStanding Standing);
    }
}
