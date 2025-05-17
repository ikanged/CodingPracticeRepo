using System;
using CodingPractice.Helpers;
using System.Collections.Generic;
using CodingPractice.Problems.Interview;
using CodingPractice;
using CodingPractice.Problems.Interview.RockStar;
using CodingPractice.Enums;

namespace Interview
{
	public class InterviewQuestions : AbsDomain
    {
        private Dictionary<int, AbsProblem> interviewProblems = new Dictionary<int, AbsProblem>();

        public InterviewQuestions()
		{
		}

        public override bool BeginProblem(int iUserInput)
        {
            AbsProblem problem;
            ProblemChoices choices = ProblemChoices.SameProblem;

            do
            {
                if (interviewProblems.TryGetValue(iUserInput, out problem))
                {
                    DisplayMessage("*-----------------------*");
                    problem.Begin();
                }
                else
                {
                    DisplayMessage("*-----------------------*");
                    DisplayMessage("Problem Not Found. Enter Valid Problem");
                }
              choices = problem.RunAgain();
            } while (choices == ProblemChoices.SameProblem);

            return choices == ProblemChoices.Domain;
        }

        public override void DisplayProblems()
        {
            for (int i = 1; i <= interviewProblems.Count; i++)
            {
                Console.WriteLine($"{i}. {interviewProblems[i]}");
            }
        }

        public override void InitializeProblems()
        {
            if(interviewProblems.Count == 0)
            {
                interviewProblems.Add(1, new PairsAndTriple());
                interviewProblems.Add(2, new RockStarDemo());
            }
        }
    }
}

