using System;
namespace CodingPractice.Problems.GeeksForGeeks
{
	public class MinimumNumberOfJumps : AbsProblem, IProblem
    {
        /*
         * Given an array of N integers arr[] where each element represents the maximum length of 
         * the jump that can be made forward from that element. This means if 
         * arr[i] = x, then we can jump any distance y such that y ≤ x.
         * Find the minimum number of jumps to reach the end of the array (starting from the first element). 
         * If an element is 0, then you cannot move through that element.
         * Note: Return -1 if you can't reach the end of the array.
         * 
         * Example: 
         * 
         * Input:
            N = 11 
            arr[] = {1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9} 
            Output: 3 
            Explanation: 
            First jump from 1st element to 2nd 
            element with value 3. Now, from here 
            we jump to 5th element with value 9, 
            and from here we will jump to the last. 
         * 
         */

        public MinimumNumberOfJumps() : base("Minimum Number Of Jumps")
		{

		}

        public override void Begin()
        {
            var inputData = new int[] { 1, 3, 5, 8, 9, 2, 6, 7, 6, 8, 9 };
            int numElements = inputData.Length;

            DisplayMessage($"Number of jumps: {GetNumberOfJumps(inputData, numElements)}");
        }

        public int GetNumberOfJumps(int[] inputData, int length)
        {
            int currentJumpLength = 1;
            int cumulativeJumps = 0;
            int numJumps = -1;

            do
            {
                if (inputData[currentJumpLength - 1] <= 0 && cumulativeJumps < length)
                {
                    //Cannot reach end of array
                    return -1;
                }

                if (cumulativeJumps <= length - 1)
                {
                    cumulativeJumps += inputData[cumulativeJumps - 1];
                    numJumps++;

                    //set jump count to element 
                    currentJumpLength = inputData[currentJumpLength - 1];
                }

                DisplayMessage($"currentJumpLength: {currentJumpLength}, cumulativeJumps: {cumulativeJumps}, numJumps: {numJumps}");

            } while (cumulativeJumps <= length);

            return numJumps;
        }
    }
}

