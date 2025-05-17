using System.Collections.Generic;
using System;
using CodingPractice;
using CodingPractice.Helpers;
using ProjectEuler;
using UdemyCodingBootcamp;
using CodingPractice.Enums;

namespace UdemyAlgorithms
{
	class UdemyCodingBootcampProblems : AbsDomain
	{
		//Collection of all Project Euler Problems
		private Dictionary<int, AbsProblem> problems = new Dictionary<int, AbsProblem>();

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

		public override void InitializeProblems()
		{
			if (problems.Count == 0)
			{
				problems.Add(1, new StringReversal());
				problems.Add(2, new Palindromes());
				problems.Add(3, new ReverseInt());
				problems.Add(4, new MaxChar());
				problems.Add(5, new ChunkArray());
				problems.Add(6, new StepPrinting());
			}
		}
	}
}
