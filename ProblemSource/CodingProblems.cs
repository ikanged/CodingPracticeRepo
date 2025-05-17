using System;
using System.Collections.Generic;
using CodingPractice;
using CodingPractice.Problems.Other_Code_Problems;
using CodingPractice.Helpers;
using CodingPractice.Enums;

namespace CodingProblem
{
    class CodingProblems : AbsDomain
    {
        private Dictionary<int, AbsProblem> codingProblems = new Dictionary<int, AbsProblem>();

        public CodingProblems()
        {
        }

        public override void InitializeProblems()
        {
            codingProblems.Add(1, new BSTCheck());
            codingProblems.Add(2, new AlgorithmSwap());
            codingProblems.Add(3, new StringOrder());
        }
        
        public override bool BeginProblem(int iUserInput)
        {
            AbsProblem problem;
            ProblemChoices choices = ProblemChoices.Domain;
            do
            {
                if (codingProblems.TryGetValue(iUserInput, out problem))
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
            for (int i = 1; i <= codingProblems.Count; i++)
            {
                Console.WriteLine($"{i}. {codingProblems[i]}");
            }
        }
    }
}
