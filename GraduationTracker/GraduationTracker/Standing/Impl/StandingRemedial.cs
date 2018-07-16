using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.AcademicStanding
{
    public class StandingRemedial : IStanding
    {
        private IStanding NextStanding;

        public Standing GetStanding(int Average)
        {
            if (Average < 50)
                return Standing.Remedial;

            return NextStanding.GetStanding(Average);
        }

        public void SetNextStandingVerification(IStanding Standing)
        {
            this.NextStanding = Standing;
        }
    }
}
