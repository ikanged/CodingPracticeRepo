using System.Collections.Generic;
using System;
using CodingPractice;
using CodingPractice.Helpers;
using CodingPractice.Enums;

namespace ProjectEuler
{
    public class ProjectEulerProblems : AbsDomain
    {
        //Collection of all Project Euler Problems
        private Dictionary<int, AbsProblem> problems = new Dictionary<int, AbsProblem>();

        public override void InitializeProblems()
        {
            if (problems.Count == 0)
            {
                problems.Add(1, new MultiplesOf3Or5());
                problems.Add(2, new EvenFibonacciNumbers());
            }
        }

        public override bool BeginProblem(int input)
        {
            AbsProblem problem = null;
            ProblemChoices choices = ProblemChoices.SameProblem;

            do
            {
                if (problems.TryGetValue(input, out problem))
                {
                    DisplayMessage("*-----------------------*");
                    problem?.Begin();
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
            for (int i = 1; i <= problems.Count; i++)
            {
                Console.WriteLine($"{i}. {problems[i]?.Name}");
            }
        }

    }
}
