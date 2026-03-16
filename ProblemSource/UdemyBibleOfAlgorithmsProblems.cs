using System.Linq;
﻿using System.Collections.Generic;
using System;
using CodingPractice;
using CodingPractice.Helpers;
using ProjectEuler;
using UdemyBibleOfAlgorithms;
using CodingPractice.Enums;

namespace UdemyAlgorithms
{
	public class UdemyBibleOfAlgorithmsProblems : AbsDomain
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
				problems.Add(1, new PrimeNumberTest());
				problems.Add(2, new PrimeFactorization());
				problems.Add(3, new PrimeSieveOfEratosthenes());
			}
		}

		public override IReadOnlyDictionary<int, string> GetProblems()
		{
			InitializeProblems();
			return problems.ToDictionary(kvp => kvp.Key, kvp => kvp.Value?.Name ?? "Unknown");
		}
	}
}
