using CarrerCruising.GraduationTracker.AcademicStanding;
using CarrerCruising.GraduationTracker.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerCruising.GraduationTracker.Service
{
    public class StudentService
    {
        public static int CalculateAverageForDiplomaRequirements(List<Requirement> listDiplomaRequirements, List<StudentProgress> listStudentProgress)
        {
            int average = 0;
            foreach (Requirement requirement in listDiplomaRequirements)
            {
                var studentProgress = listStudentProgress.Where(progress => progress.Course.Id == requirement.Course.Id).FirstOrDefault();
                average += studentProgress.Mark;
            }

            return average / listStudentProgress.Count;
        }

        public static int CalculateCreditForDiplomaRequirements(List<Requirement> listDiplomaRequirements, List<StudentProgress> listStudentProgress)
        {
            int credits = 0;
            foreach (Requirement requirement in listDiplomaRequirements)
            {
                var studentProgress = listStudentProgress.Where(progress => progress.Course.Id == requirement.Course.Id).FirstOrDefault();

                if (studentProgress.Mark > requirement.MinimumMark)
                    credits += requirement.Credits;
            }
            return credits;
        }

        public static Standing GetAcademicStanding(int studentAverage, int studentCredits, int diplomaCredits)
        {
            if (studentCredits < diplomaCredits)
                return Standing.Remedial;

            StandingRemedial remedial = new StandingRemedial();
            StandingAverage average = new StandingAverage();
            StandingMagnaCumLaude magnaCumLaude = new StandingMagnaCumLaude();
            StandingSumaCumLaude sumaCumLaude = new StandingSumaCumLaude();
            StandingNone none = new StandingNone();

            remedial.SetNextStandingVerification(average);

            average.SetNextStandingVerification(magnaCumLaude);

            magnaCumLaude.SetNextStandingVerification(sumaCumLaude);

            sumaCumLaude.SetNextStandingVerification(none);

            return remedial.GetStanding(studentAverage);
        }

        public static bool IsGraduated(Standing standing)
        {
            switch (standing)
            {
                case Standing.Remedial:
                    return false;
                case Standing.Average: case Standing.SumaCumLaude: case Standing.MagnaCumLaude:
                    return true;
                default:
                    return false;
            }
        }
    }
}
