using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.AcademicStanding
{
    public class StandingNone : IStanding
    {
        public Standing GetStanding(int Average)
        {
             return Standing.None;
        }

        public void SetNextStandingVerification(IStanding Standing)
        {
        }
    }
}
