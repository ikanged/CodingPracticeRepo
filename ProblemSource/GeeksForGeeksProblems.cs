using System;
using CodingPractice;
using System.Collections.Generic;
using CodingPractice.Problems.GeeksForGeeks;
using CodingPractice.Helpers;
using CodingPractice.Enums;

namespace GeeksForGeeks
{
    public class GeeksForGeeksProblems : AbsDomain
    {
        private Dictionary<int, AbsProblem> gfgProblems = new Dictionary<int, AbsProblem>();

        public GeeksForGeeksProblems()
        {
        }

        public override bool BeginProblem(int iUserInput)
        {
            AbsProblem problem;
            ProblemChoices choices = ProblemChoices.SameProblem;

            do
            {
                if (gfgProblems.TryGetValue(iUserInput, out problem))
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
            for (int i = 1; i <= gfgProblems.Count; i++)
            {
                Console.WriteLine($"{i}. {gfgProblems[i]}");
            }
        }

        public override void InitializeProblems()
        {
            gfgProblems.Add(1, new HeightOfBinaryTree());
            gfgProblems.Add(2, new MinimumNumberOfJumps());
        }
    }
}
