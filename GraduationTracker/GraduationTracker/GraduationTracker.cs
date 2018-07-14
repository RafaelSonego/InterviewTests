using CarrerCruising.GraduationTracker.Repository.Impl;
using CarrerCruising.GraduationTracker.Repository.Impl.Mock;
using CarrerCruising.GraduationTracker.Repository.Model;
using CarrerCruising.GraduationTracker;
using GraduationTracker.Repository.Impl.Mock;
using System;

namespace GraduationTracker
{
    public partial class GraduationTracker
    {
        //BUG hasgraduated method needs return a bool or change the name of the method
        public Tuple<bool, STANDING> HasGraduated(Diploma diploma, Student student)
        {
            RequirementRepositoryMock requirementRepository = new RequirementRepositoryMock();

            //student credits
            var credits = 0;
            //Student avarege
            var average = 0;

            //Each diploma has a list of requirements and each requirement has a list of the courses and credits score
            //Check if it can be changed to be a list of objects

            //For each diploma requirements..
            for (int i = 0; i < diploma.Requirements.Length; i++)
            {
                //For each students course
                for (int j = 0; j < student.Courses.Length; j++)
                {
                    //Get the diploma requirement
                    //Change to outside of the for looping
                    var requirement = requirementRepository.GetByID(diploma.Requirements[i]);

                    //For each courses of requirement
                    for (int k = 0; k < requirement.Courses.Length; k++)
                    {
                        //Check if the student has the course required by requirement diploma
                        if (requirement.Courses[k] == student.Courses[j].Id)
                        {
                            //If student has the course required by diploma requirements we add the course mark (score) with the student average
                            average += student.Courses[j].Mark;

                            //If the student has the score(mark) greater than the minimum mark(minimum score) of the requirement, the requirement credit is added to the student credit
                            if (student.Courses[j].Mark > requirement.MinimumMark)
                            {
                                credits += requirement.Credits;
                            }
                        }
                    }
                }
            }


            // Calculate the student average by current average divided by student courses
            average = average / student.Courses.Length;

            //Status of the student graduate
            var standing = STANDING.None;


            //Status Remedial if average is less than 50
            if (average < 50)
            {
                standing = STANDING.Remedial;
            }
            //Status average  50 - 79
            else if (average < 80)
            {
                standing = STANDING.Average;
            }
            //Status MagnaCumLaude 80 - 94
            else if (average < 95)
            {
                standing = STANDING.MagnaCumLaude;
            }
            //Status SumaCumLaude >= 95
            else
            {
                standing = STANDING.MagnaCumLaude; // BUG STANDING.SumaCumLaude
            }

            //BUG graduated and not graduated will be returned
            switch (standing)
            {
                case STANDING.Remedial:
                    return new Tuple<bool, STANDING>(false, standing);//Not graduated
                case STANDING.Average:
                    return new Tuple<bool, STANDING>(true, standing);
                case STANDING.SumaCumLaude:
                    return new Tuple<bool, STANDING>(true, standing);
                case STANDING.MagnaCumLaude:
                    return new Tuple<bool, STANDING>(true, standing);

                default:
                    return new Tuple<bool, STANDING>(false, standing);
            }
        }
    }
}
