using System;
using System.Collections.Generic;
using System.Text;
using CodingPractice;

namespace UdemyBibleOfAlgorithms
{
	class PrimeFactorization : AbsProblem, IProblem
	{
		/*
		 * Example: 
		 * Enter Number:
			14525
			Prime Factors of 14525:
			5^2
			7^1
			83^1
		 * 
		 */

		struct PrimeFactor
		{
			public Dictionary<int, int> Factors;
		}

		public PrimeFactorization() : base("Prime Factorization")
		{

		}

		public override void Begin()
		{
			UserInput userInput = new UserInput();
			var input = userInput.intUserInput();

			DisplayMessage($"Prime Factors of {input}:");
			DisplayPrimeFactors(GetPrimeFactors(input));
		}

		private PrimeFactor GetPrimeFactors(int number)
		{
			//64 -> 2^6
			var result = new List<int>();

			int exp = 0;
			//Initialize the factor to be 2
			int factor = 2;

			PrimeFactor primeFactor = new PrimeFactor();
			primeFactor.Factors = new Dictionary<int, int>();

			//If the factor squared is less than the prime number, we can conclude that 
			// there will be no more prime factors after this factor
			while (number > 1 && (factor * factor) <= number)
			{
				//Reset exp count
				exp = 0;
				
				//if number is divisible by the factor then
				//divide the number and increment the expnonent count
				while(number % factor == 0)
				{
					number /= factor;
					exp++;
				}

				if (exp > 0)
				{
					primeFactor.Factors.Add(factor, exp);
				}

				//Go to the next number
				factor++;
			}

			//saving the prime number it self
			if(number > 1)
			{
				exp = 1;
				primeFactor.Factors.Add(number, exp);
			}


			return primeFactor;
		}

		private void DisplayPrimeFactors(PrimeFactor primeFactor)
		{
			StringBuilder strBuilder = new StringBuilder();

			foreach(var prime in primeFactor.Factors)
			{
				strBuilder.AppendLine($"{prime.Key}^{prime.Value}");						
			}

			DisplayMessage(strBuilder.ToString());
		}
	}
}

