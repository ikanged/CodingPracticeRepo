using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace UdemyBibleOfAlgorithms
{
	class PrimeNumberTest : AbsProblem, IProblem
	{
		

		public PrimeNumberTest() : base("Prime Number Test")
		{

		}

		public override void Begin()
		{
			UserInput userInput = new UserInput();
			var input = userInput.intUserInput();

			DisplayMessage($"{input} is {(isPrimeNumber(input) ? "a Prime Number" : "Not a Prime Number")}");
		}

		public bool isPrimeNumber(int number)
		{
			List<int> primes = new List<int>();

			if(number > int.MaxValue)
			{
				DisplayMessage($"Enter Number that is less than {int.MaxValue}");
				return false;
			}

			if(number < 0)
			{
				DisplayMessage($"Enter Positive Number");
				return false;
			}

			for(int i = 2; i < Math.Sqrt((double)number); i++)
			{
				if(number % i == 0)
				{
					return false;
				}
			}

			return true;
		}
	}
}
