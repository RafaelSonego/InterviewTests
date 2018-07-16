using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.AcademicStanding
{
    public class StandingAverage : IStanding
    {
        private IStanding NextStanding;

        public Standing GetStanding(int Average)
        {
            if (Average < 80)
                return Standing.Average;

            return NextStanding.GetStanding(Average);
        }

        public void SetNextStandingVerification(IStanding Standing)
        {
            this.NextStanding = Standing;
        }
    }
}
