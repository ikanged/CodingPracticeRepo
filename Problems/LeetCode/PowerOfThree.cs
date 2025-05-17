using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingPractice.Problems.LeetCode
{
	public class PowerOfThree : AbsProblem, IProblem
	{
		public PowerOfThree() : base("Power Of Three")
		{
            /*
             *  
             *   Given an integer n, return true if it is a power of three. Otherwise, return false.
             *   An integer n is a power of three, if there exists an integer x such that n == 3^x.
             *  
             *  Input: n = 27
             *  Output: true
             *  
             *
             */
        }

        public override void Begin()
        {
            int input = 45;

            //Should Return false
            DisplayArray($"{isPowerOfThree(input)}");            
        }

        public bool isPowerOfThree(int input)
        {
            if (input == 1)
            {
                return true;
            }
            if (input < 3)
            {
                return false;
            }

            //Loop until the input cannot be divided any more
            while(input > 1)
            {
                //If it is divisible by 3, keep on dividing
                if (input % 3 == 0)
                {
                    input /= 3;
                    continue;
                }

                return false;
            }

            return true;
        }
    }
}

