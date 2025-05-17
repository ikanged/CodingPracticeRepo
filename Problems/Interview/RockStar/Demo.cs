using System;
namespace CodingPractice.Problems.Interview.RockStar
{
	public class RockStarDemo : AbsProblem, IProblem
    {
		public RockStarDemo() : base("Rockstar Demo problem")
		{
            /*
             * Write a function that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

                For example:
                Given A = [1, 3, 6, 4, 1, 2], the function should return 5.

                Given A = [1, 2, 3], the function should return 4.

                Given A = [−1, −3], the function should return 1.

                Write an efficient algorithm for the following assumptions:

                N is an integer within the range [1..100,000];
                each element of array A is an integer within the range [−1,000,000..1,000,000].
            */
		}

        public override void Begin()
        {
            //{ 1, 3, 6, 4, 1, 2 }   //Answer: 5
            int[] input = new int[] { -1, -3 };   //Answer: 1

            DisplayMessage($"Smallest positive int is: {smallestPosInt(input)}");            
        }

        public int smallestPosInt(int[] input)
        {
            int smallestInt = 1;
            /*
             * 1, 3, 6, 4, 1, 2
             *      
             * 1, 1, 2, 3, 4, 6
             * smallestInt == nextNum
             * x  x  +1 +1 +1 5
             * 
             */

            Array.Sort(input);

            foreach (int num in input)
            {
                if(smallestInt == num)
                {
                    smallestInt++;
                    continue;
                }
                else if(smallestInt > num)
                {
                    continue;
                }
                else if(smallestInt < num)
                {
                    break;
                }
            }

            return smallestInt;
        }
    }
}

