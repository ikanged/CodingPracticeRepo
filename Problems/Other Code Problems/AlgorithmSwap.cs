using System;
using System.Collections.Generic;
using System.Text;

namespace CodingPractice.Problems.Other_Code_Problems
{
	class AlgorithmSwap : AbsProblem, IProblem
	{
		/*
		 *	This problem was given on an Online Assessment from Amazon.  
		 *	
		 *		 
		 */
		public AlgorithmSwap() : base("Amazon's Algorithm Swap")
		{

		}
		public override void Begin()
		{
			UserInput userInput = new UserInput();

			DisplayMessage("1. Brute Force Method?");
			DisplayMessage("2. Optimized Solution?");

			//99999 - chokes 
			int[] input = RandomNumber.getRandomNumbers(30, 99999);

			//displayNumbers(input);

			switch (userInput.intUserInput())
			{
				case 1:
					{
						DisplayMessage("Starting Brute Force method:");
						BruteForce(input);
						break;
					}
				case 2:
					{
						DisplayMessage("Starting Optimized solution (Merge Sort)");
						//OptimizedSolution(input);
						break;
					}
			}
		}

		private void BruteForce(int[] arr)
		{
			int swaps = 0;

			if (arr.Length > 0)
			{
				for (int i = 0; i < arr.Length - 1; i++)
				{
					for (int j = i + 1; j < arr.Length; j++)
					{
						if (arr[i] > arr[j])
						{
							swaps++;
						}
					}
				}
			}

			DisplayMessage($"Number of swaps: {swaps}");
		}

		//private int[] OptimizedSolution(int[] arr)
		//{
		//	if (arr.Length <= 1)
		//	{
		//		return arr;
		//	}


		//}

		private void displayNumbers(int[] numbers)
		{
			string strNumbers = "";
			foreach (int number in numbers)
			{
				strNumbers += $"{number}" + ", ";
				DisplayMessage(strNumbers);
			}
		}
	}
}
