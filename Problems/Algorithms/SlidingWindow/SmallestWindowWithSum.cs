using System;
namespace CodingPractice.Problems.Algorithms.SlidingWindow
{
	public class SmallestWindowWithSum : AbsProblem, IProblem
	{
		public SmallestWindowWithSum() : base("Smallest Subarray With Given Sum")
		{
			/*
			 * 
			 * Problem: Find the smalled window for the given sum
			 * Input: [4,2,2,7,8,1,2,8,1,0]
			 * Target Sum: 8
			 * Output: 1
			 * 
			 */

		}

        public override void Begin()
        {
			int[] input = new int[] { 4, 2, 2, 7, 8, 1, 2, 8, 1, 0 };
			int sum = 8;

			DisplayMessage($"Small window Size: {smallestWindowSum(input, sum)}");
        }

		public int smallestWindowSum(int[] input, int sum)
		{
			int windowSize = input.Length;
			int windowStart = 0;
			int currentSum = 0;
			int currentWindowSize = 0;

			for(int windowEnd = 0; windowEnd < input.Length; windowEnd++)
			{
				//Save the currentSum
				currentSum += input[windowEnd];

				//Shrink the window from the left side
				while(currentSum >= sum)
				{
					currentWindowSize = (windowEnd - windowStart);
					//base case
					if (currentSum == sum && (currentWindowSize == 0))
					{
						return 1;
					}
					else
					{
						windowSize = Math.Min(currentWindowSize + 1, windowSize);
						currentSum = currentSum - (input[windowStart]);
						windowStart++;
					}
				}
			}			
			return windowSize;
		}
    }
}

