using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice.Helpers;

namespace CodingPractice
{
	public abstract class ProblemFactory : AbsProblemFactory
	{
		public abstract void InitializeDomains();
		public abstract void DisplayDomains();


		public bool ExecuteProblem(AbsDomain domain, bool runAgain = false)
		{
			UserInput _userInput = new UserInput();

			if(!runAgain)
			{
				domain.InitializeProblems();
			}
			
			domain.DisplayProblems();

			Console.WriteLine("Choose Problem To Solve: ");
			var iUserInput = _userInput.intUserInput();

			Console.WriteLine($"*-------------------*");

			return domain.BeginProblem(iUserInput);
		}
	}
}
 