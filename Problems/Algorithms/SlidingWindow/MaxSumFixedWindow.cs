using System;
using CodingPractice;

namespace Algorithms
{
    public class MaxSumFixedWindow : AbsProblem, IProblem
    {
        public MaxSumFixedWindow() : base("Sliding Window")
        {
            /*
             * Find the max sum subarray of a fixed size K
             
             * Example Inputd
             * [4,2,1,7,8,1,2,8,1,0]
             * k = 3 (Window Size)
             *  OutPut: 16
             
             */
        }

        public override void Begin()
        {

            int windowSize = 3;
            int[] array = new int[] { 4, 2, 1, 7, 8, 1, 2, 8, 1, 0 };
            DisplayMessage("-----------------------------------");
            //Algorithm
            /*
             * First iteration wil give take the sum of 
             * all numbers up to the window size
             * 
             */
            DisplayMessage($"Answer: {getMaxSum(array, windowSize)}");            
        }

        public int getMaxSum(int[] input, int windowSize)
        {
            int currentSum = 0;
            int maxSum = 0;

            //Get initial sum
            for (int i = 0; i < input.Length; i++)
            {
                currentSum += input[i];

                //Begin to consider window 
                if(i >= windowSize-1)
                {
                    maxSum = Math.Max(currentSum, maxSum);
                    //Move the window to the Right by subtracting the
                    //Left most element from the window from the Current Sum
                    currentSum = currentSum - input[i - (windowSize - 1)];                         
                }
            }

            return maxSum;
        }
    }
}

