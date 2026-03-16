using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Helpers
{
	public abstract class AbsDomain
	{
		public abstract bool BeginProblem(int input);

		public abstract void InitializeProblems();
		public abstract void DisplayProblems();
		public abstract IReadOnlyDictionary<int, string> GetProblems();

		public void DisplayMessage(string msg)
		{
			Console.WriteLine(msg);		
		}
	}
}
