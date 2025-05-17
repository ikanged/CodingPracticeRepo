using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CodingPractice;

namespace UdemyBibleOfAlgorithms
{
	class PrimeSieveOfEratosthenes : AbsProblem, IProblem
	{
		/*
		 * Sieve of Eratosthenes 
		 * An algorthim that will find all the prime numbers
		 * by eliminating all the multiples of prime numbers 
		 * up to the given number
		 * 
		 * Below Code can be optimized. to O(input * log(input))
		 */
		public PrimeSieveOfEratosthenes() : base("Sieve of Eratosthenes")
		{

		}

		public override void Begin()
		{
			UserInput userInput = new UserInput();
			var input = userInput.intUserInput();

			DisplayMessage($"Prime Factors of {input}:");
			DisplayPrimeNumbers(GetPrimeNumbers(input));
		}

		private int[] GetPrimeNumbers(int input)
		{
			int[] numbersArray = new int[input];	

			for (int i = 2; i < input; i++)
			{
				if (input % i == 0)
				{
					numbersArray[0] = 1;
				}

				if (numbersArray[i] != 1)
				{
					for(int j = i; j < numbersArray.Length; j+=i)
					{
						if (j == i)
							continue;
						if(j % i == 0)
						{
							numbersArray[j] = 1;
						}

						
					}
				}
			}

			return numbersArray;
		}

		private void DisplayPrimeNumbers(int[] primes)
		{
			StringBuilder strBuilder = new StringBuilder();

			for (int i = 2; i < primes.Length; i++)
			{
				if (primes[i] == 0)
				{
					strBuilder.AppendLine($"{i}");
				}
			}

			if (primes[0] != 1)
			{
				strBuilder.AppendLine($"{primes.Length}");
			}
			DisplayMessage(strBuilder.ToString());
		}
	}
}
